using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ViewGrpMarksForm : Form
    {
        List<Group> grps = new List<Group>();
        public ViewGrpMarksForm(List<Group> grps)
        {
            InitializeComponent();
            this.grps = grps;
            FillDataGrid();
        }

        private void FillDataGrid()
        {

            //create student list and add all the students from the groups to that list
            List<Student> students = new List<Student>();
            foreach (Group grp in grps)
                students.AddRange(grp.Students);

            //show the data from the student list to table
            var studentList = from stu in students
                              select new
                              {
                                  GroupId = stu.GroupID,
                                  GroupMarks = grps.Where(g => g.Id == stu.GroupID).FirstOrDefault().Marks,
                                  StudentId = stu.ID,
                                  FirstName = stu.FirstName,
                                  StudentMarks = stu.Marks,
                              };
            dataGridView1.DataSource = studentList.ToList();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
