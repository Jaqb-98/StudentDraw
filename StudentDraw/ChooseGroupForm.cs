using StudentDrawClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDraw
{
    public partial class ChooseGroupForm : Form
    {
        public ChooseGroupForm()
        {
            InitializeComponent();
        }

        private void LoadGroupList_Load(object sender, EventArgs e)
        {
            using (var context = new SDContext())
            {
                var groups = context.Groups.OrderBy(g => g.GroupID).Select(g => new { Name = g.GroupName, Number = g.GroupNumber + g.GroupSign }).ToList();
                dgv_AvilableGroups.DataSource = groups;
            }
        }

        private void dgv_AvilableGroups_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            int groupID;
            using (var context = new SDContext())
            {
                groupID = context.Groups.OrderBy(g => g.GroupID).Skip(e.RowIndex).Select(g => g.GroupID).FirstOrDefault();
            }
            var form = new PresenceCheckForm(groupID);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.ShowDialog();
            this.Close();

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
