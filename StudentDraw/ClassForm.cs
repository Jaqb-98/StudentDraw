using StudentDrawClassLibrary;
using StudentDrawClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDraw
{
    public partial class ClassForm : Form
    {
        public int ClassID { get; set; }
        public Answers CurrentAnswers { get; set; }
        public ClassForm(int classID)
        {
            ClassID = classID;
            InitializeComponent();
        }

        private void btn_DrawStudent_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            using (var context = new SDContext())
            {
                var Class = context.Classes
                  .Include(c => c.PresentStudents)
                  .Include(c => c.Answers)
                  .Where(c => c.ID == ClassID)
                  .FirstOrDefault();


                var randomStudent = Class.PresentStudents.OrderBy(s => Guid.NewGuid()).FirstOrDefault();



                lbl_Name.Text = string.Format($"{randomStudent.Name} {randomStudent.LastName}");

                var answers = Class.Answers.Where(a => a.Student.ID == randomStudent.ID).FirstOrDefault();

                CurrentAnswers = answers;

                int answersCount = answers.AnswersCount;
                lbl_AnswerCounter.Text = string.Format($"Answers: {answers.AnswersCount}");




            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            using (var context = new SDContext())
            {
                var Class = context.Classes
               .Include(c => c.PresentStudents)
               .Include(c => c.Answers)
               .Where(c => c.ID == ClassID)
               .FirstOrDefault();

                if (rb_Answered.Checked)
                {
                    context.Answers.Where(a => a.ID == CurrentAnswers.ID).FirstOrDefault().AnswersCount++;
                }

                context.SaveChanges();

            }

        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            using (var context = new SDContext())
            {
                var Class = context.Classes
                    .Include(c => c.PresentStudents)
                    .Where(c => c.ID == ClassID)
                    .FirstOrDefault();

                foreach (var student in Class.PresentStudents)
                {
                    context.Answers.Add(new Answers() { Class = Class, Student = student, AnswersCount = 0 });
                }

                context.SaveChanges();

            }
        }
    }
}
