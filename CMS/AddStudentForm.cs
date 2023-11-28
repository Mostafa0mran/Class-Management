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
    public partial class AddStudentForm : Form
    {
        List<Student> students;
        public AddStudentForm(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void canclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //empty input added
            if (idBox.Text == "" || fnameBox.Text == "" || lnameBox.Text == "" || emailBox.Text == "")
            {
                MessageBox.Show("Emtpy Input not acceptable. Please provide all the details");
                return;
            }

            //invalid input for id
            int id;
            if(!int.TryParse(idBox.Text, out id))
            {
                MessageBox.Show("Invalid input for id. Please provide a number for the id!");
                return;
            }

            //if id is already present
            if(idPresent(id))
            {
                MessageBox.Show("A student is already present with the given id. Please provide a unique id!");
                return;
            }

            //add student to the student list and return
            students.Add(new Student(id, fnameBox.Text, lnameBox.Text, emailBox.Text));
            FileHandler.StoreStudents(students);
            MessageBox.Show("Student added successfully");
            this.Close();
        }

        //if id is already present then return true
        private bool idPresent(int id)
        {
            if (students.Where(s => s.ID == id).Any())
                return true;
            return false;
        }
    }
}
