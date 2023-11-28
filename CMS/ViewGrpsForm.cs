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
    public partial class ViewGrpsForm : Form
    {
        List<Group> grps = new List<Group>();
        string sortingOrder;
        public ViewGrpsForm(List<Group> grps, string sortingOrder)
        {
            InitializeComponent();
            this.grps = grps;
            this.sortingOrder = sortingOrder;
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            //sort groups by id
            if(sortingOrder=="ID")
                SortListByID();

            //create student list and add all the students from the groups to that list
            List<Student> students = new List<Student>();
            foreach(Group grp in grps)
                students.AddRange(grp.Students);

            if(sortingOrder != "ID")
            {
                students = students.OrderBy(s => s.LastName).ToList();
            }

            //show the data from the student list to table
            var studentList = from stu in students
                              select new
                              {
                                  GroupId = stu.GroupID,
                                  StudentId = stu.ID,
                                  FirstName = stu.FirstName,
                                  LastName = stu.LastName,
                              };
            dataGridView1.DataSource = studentList.ToList();
        }

        private void SortListByID()
        {
            //bubble sort algorithm
            for (int i = 0; i < grps.Count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (grps[j - 1].Id > grps[j].Id)
                    {
                        Group temp = grps[j - 1];
                        grps[j - 1] = grps[j];
                        grps[j] = temp;
                    }
                }
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
