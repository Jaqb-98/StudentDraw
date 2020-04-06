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
    public partial class PresenceCheckForm : Form
    {
        public int GroupID { get; set; }
        public PresenceCheckForm(int groupID)
        {
            GroupID = groupID;
            InitializeComponent();
        }

        private void PresenceCheckForm_Load(object sender, EventArgs e)
        {

            using (var context = new SDContext())
            {
                var group = context.Groups.Where(g => g.GroupID == this.GroupID).FirstOrDefault();

                DataGridViewCheckBoxColumn checkBoxCloumn = new DataGridViewCheckBoxColumn();
                checkBoxCloumn.HeaderText = "Present";
                checkBoxCloumn.Width = 70;
                checkBoxCloumn.Name = "PresentCheckBox";
                dgv_PresenceCheck.Columns.Insert(0, checkBoxCloumn);
                dgv_PresenceCheck.DataSource = group.Students.ToList();

                foreach (DataGridViewColumn column in dgv_PresenceCheck.Columns)
                {
                    if (column.HeaderText == "ID")
                        column.Visible = false;
                    else if (column.HeaderText == "GroupID")
                        column.Visible = false;
                    else if (column.HeaderText == "Group")
                        column.Visible = false;
                    else if (column.HeaderText == "Answers")
                        column.Visible = false;
                    else if (column.HeaderText == "Classes")
                        column.Visible = false;
                }

            }
        }

        private void btn_MarkAsPresent_Click(object sender, EventArgs e)
        {
            Class newClass;
            using (var context = new SDContext())
            {
                ICollection<Student> presentStudents = new List<Student>();

                foreach (DataGridViewRow row in dgv_PresenceCheck.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["PresentCheckBox"].Value);
                    Student a = (Student)row.DataBoundItem;
                    if (isSelected)
                    {
                        presentStudents.Add(context.Students
                            .Include(s => s.Answers)
                            .Include(s => s.Classes)
                            .Include(s => s.Group)
                            .Where(s => s.ID == a.ID)
                            .FirstOrDefault());
                    }
                }
                var group = context.Groups
                    .Include(g => g.Students)
                    .Include(g => g.Classes)
                    .Where(g => g.GroupID == this.GroupID)
                    .FirstOrDefault();

                newClass = new Class() { Group = group, Date = DateTime.Now, PresentStudents = presentStudents };
                context.Classes.Add(newClass);
                context.SaveChanges();
            }

            this.Hide();
            var form = new ClassForm(newClass.ID);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.ShowDialog();
            this.Close();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ChooseGroupForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.ShowDialog();
            this.Close();
        }
    }
}
