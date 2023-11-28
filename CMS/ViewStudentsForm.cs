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
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm(List<Student> students)
        {
            InitializeComponent();
            loadStudents(students);
        }

        private void loadStudents(List<Student> students)
        {
            //get all the students from the file and only show the id,
            //name and email of the student in the table
            var studentList = from stu in students
                           select new
                           {
                               Id = stu.ID,
                               FirstName = stu.FirstName,
                               LastName = stu.LastName,
                               Email = stu.Email
                           };
            dataGridView1.DataSource = studentList.ToList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
