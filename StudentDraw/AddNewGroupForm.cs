using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDrawClassLibrary;

namespace StudentDraw
{
    public partial class AddNewGroupForm : Form
    {
        public ICollection<Student> StudentsFromList { get; set; }
        public AddNewGroupForm()
        {
            InitializeComponent();
            StudentsFromList = new List<Student>();
        }

        private void UploadStudentsList_Click(object sender, EventArgs e)
        {
            FileDialog_UploadStudentsList.ShowDialog();
        }

        private void FileDialog_UploadStudentsList_FileOk(object sender, CancelEventArgs e)
        {

            var dialog = (OpenFileDialog)sender;
            var path = dialog.FileName;
            var fileContent = File.ReadAllText(path);



            foreach (var item in fileContent.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
            {
                var q = item.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var temp = new Student() { Name = q[0], LastName = q[1] };
                StudentsFromList.Add(temp);
            }

            dgv_StudentsList.DataSource = StudentsFromList.Select(x => new
            {
                Name = x.Name,
                LastName = x.LastName
            }).ToList();
            btn_AddGroup.Enabled = true;
        }

        private void btn_AddGroup_Click(object sender, EventArgs e)
        {
            using (var context = new SDContext())
            {
                var group = new Group() { GroupName = txtbox_GroupName.Text, GroupNumber = (int)num_GroupNumber.Value, GroupSign = txtbox_GroupSign.Text };
                context.Groups.Add(group);

                foreach (var student in StudentsFromList)
                {
                    student.Group = group;
                    context.Students.Add(student);
                }


                context.SaveChanges();

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.ShowDialog();
            this.Close();
        }
    }
}
