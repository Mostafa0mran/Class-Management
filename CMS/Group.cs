using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    public class Group
    {
        public int Id { get; set; }
        public int Marks { get; set; }
        public List<Student> Students { get; set; }

        public Group(int id, List<Student> students)
        {
            Id = id;
            Students = students;
            Marks = 0;
        }
    }
}
