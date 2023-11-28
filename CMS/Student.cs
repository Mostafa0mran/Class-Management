using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int GroupID { get; set; }
        public int Marks { get; set; }
        public Student(int iD, string firstName, string lastName, string email)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            GroupID = -1;
            Marks = 0;
        }
    }
}
