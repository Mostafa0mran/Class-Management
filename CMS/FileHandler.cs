using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CMS
{
    public static class FileHandler
    {
        //function to store students as json in a file
        public static void StoreStudents(List<Student> students)
        {
            //serialize list
            string json = JsonSerializer.Serialize(students);
            //create streamwriter object
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Students.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be found!! Storing Students data failed\n");
                Environment.Exit(0);
            }
            //store json string to file
            sw.WriteLine(json);
            //close the writer object
            sw.Close();
        }

        //function to store groups as json in a file
        public static void StoreGroups(List<Group> groups)
        {
            //serialize list
            string json = JsonSerializer.Serialize(groups);
            //create streamwriter object
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Groups.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be found!! Storing Groups data failed\n");
                Environment.Exit(0);
            }
            //store json string to file
            sw.WriteLine(json);
            //close the writer object
            sw.Close();
        }

        //read students from the file and return list of students
        public static List<Student> GetStudents()
        {
            //create a new list
            List<Student> students = new List<Student>();
            //streamReader object
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(("Students.txt"));
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be found!! Reading Students data failed\n");
                Environment.Exit(0);
            }
            //read the json string and store to list
            students = JsonSerializer.Deserialize<List<Student>>(sr.ReadLine());
            //close reader object
            sr.Close();
            //return students list
            return students;
        }

        //import students from a csv file
        public static List<Student> ImportStudentsFromCsv(string fileName,int lastStuId)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(@fileName);
            }
            catch(Exception)
            {
                MessageBox.Show("File could not be found!! Importing students failed\n");
                Environment.Exit(0);
            }

            string line;
            string[] splitedline;
            while ((line = reader.ReadLine()) != null)
            {
                splitedline = line.Split(',');
                students.Add(new Student(++lastStuId, splitedline[0], splitedline[1], splitedline[2]));
            }
            reader.Close();
            return students;
        }

        //read groups from the file and return list of groups
        public static List<Group> GetGroups()
        {
            //create a new list
            List<Group> groups = new List<Group>();
            //streamReader object
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Groups.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be found!! Reading Groups data failed\n");
                Environment.Exit(0);
            }
            //read the json string and store to list
            groups = JsonSerializer.Deserialize<List<Group>>(sr.ReadLine());
            //close reader object
            sr.Close();
            //return groups list
            return groups;
        }


    }
}
