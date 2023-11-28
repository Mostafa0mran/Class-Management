using Microsoft.VisualBasic;
namespace CMS
{
    public partial class MainForm : Form
    {
        List<Student> students;
        List<Group> groups;
        public MainForm()
        {
            InitializeComponent();
            initRecords();
        }

        private void initRecords()
        {
            students = FileHandler.GetStudents();
            groups = FileHandler.GetGroups();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewStudentsForm(students).ShowDialog();
        }

        private void addStudentToExistingGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if selection failed
            Group selectedGrp = GetFreeGroup();
            if (selectedGrp == null)
                return;

            //if selection failed
            Student selectedStu = GetFreeStudent();
            if (selectedStu == null)
                return;

            //set the groupId of the student group
            selectedStu.GroupID = selectedGrp.Id;
            //add student to the group
            selectedGrp.Students.Add(selectedStu);

            //update the data in the files
            FileHandler.StoreStudents(students);
            FileHandler.StoreGroups(groups);
            MessageBox.Show("Student has been added to the group successfully");
        }

        private Group GetFreeGroup()
        {
            Group group = GetExistingGroup();

            if (group == null)
                return null;

            //if the group is filled
            if (group.Students.Count == 4)
            {
                MessageBox.Show("There is no free space in this group!");
                return null;
            }

            return group;
        }
        private Group GetExistingGroup()
        {
            //get the group id from the user
            string grpIdInput = Interaction.InputBox("Enter the Id of an existing group: ", "Enter Group Id", "");

            //if invalid input
            int grpId = 0;
            if (!int.TryParse(grpIdInput, out grpId))
            {
                MessageBox.Show("Invalid Input!");
                return null;
            }

            //get the selected group
            Group group = groups.Where(g => g.Id == grpId).FirstOrDefault();

            if (group == null)
            {
                MessageBox.Show("No group is present with the given id!");
                return null;
            }

            return group;
        }
        private Student GetFreeStudent()
        {
            Student student = GetExistingStu();
            if (student == null)
                return student;

            //if student is assigned to some other group
            if (student.GroupID != -1)
            {
                MessageBox.Show("The student is already present in some other group..");
                return null;
            }

            return student;
        }

        private Student GetExistingStu()
        {
            //get the student id from the user
            string stuIdInput = Interaction.InputBox("Enter the Id of an existing student : ", "Enter student Id", "");

            //if invalid input
            int stuId = 0;
            if (!int.TryParse(stuIdInput, out stuId))
            {
                MessageBox.Show("Invalid Input!");
                return null;
            }

            //get the selected student
            Student student = students.Where(s => s.ID == stuId).FirstOrDefault();

            if (student == null)
            {
                MessageBox.Show("No student is present with the given id!");
                return null;
            }

            return student;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddStudentForm(students).ShowDialog();
            students = FileHandler.GetStudents();
        }

        private void importStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            //open the filedailog
            using (var selectFileDialog = new OpenFileDialog())
            {
                //if a file is selected then get the file name
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = selectFileDialog.FileName;
                }
                else //if canceled then return
                {
                    return;
                }
            }

            //read the file and get students
            List<Student> importedStudents = FileHandler.ImportStudentsFromCsv(fileName, students.Count);

            //if empty file
            if (importedStudents == null)
                return;
            //add students to current list
            foreach (Student s in importedStudents)
                students.Add(s);

            //store student in the students file
            FileHandler.StoreStudents(students);
            //show message
            MessageBox.Show("Students imported succesfully!");
        }

        private void sortByGroupIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sort by id
            new ViewGrpsForm(groups,"ID").ShowDialog();
        }
 

        private void sortByStudentLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sort by last name
            new ViewGrpsForm(groups,"LASTNAME").ShowDialog();
        }

        private void addStudentToNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Student> grpStudents = new List<Student>();

            //generate id of new group
            int newGrpId = groups.Count + 1;
            //get student to be added to the group
            Student selectedStu = GetFreeStudent();

            if (selectedStu == null)
                return;
                
            selectedStu.GroupID = newGrpId;

            //add grp student list
            grpStudents.Add(selectedStu);

            //add new group to the groups list
            groups.Add(new Group(newGrpId, grpStudents));

            //update the files
            FileHandler.StoreStudents(students);
            FileHandler.StoreGroups(groups);

            MessageBox.Show($"The selected student has been added to the new group with id = {newGrpId}");

        }

        private void bulkAssignStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //get students that are not in any group
            List<Student> freeStudents = students.Where(s => s.GroupID == -1).ToList();
            //if no student is free
            if (freeStudents.Count == 0)
            {
                MessageBox.Show("\nThere no students without a group...");
                return;
            }
            //get groups that are not filled completely
            List<Group> freeGroups = groups.Where(g => g.Students.Count < 4).ToList();

            //add students to free group until it is full and remove from freeStudents list an
            foreach (Group group in freeGroups)
            {
                while (freeStudents.Count != 0 && group.Students.Count < 4)
                {
                    group.Students.Add(freeStudents.ElementAt(0));
                    freeStudents.ElementAt(0).GroupID = group.Id;
                    freeStudents.RemoveAt(0);
                }
            }

            //if existing groups are filled then add remaining free students to new groups
            //while any free students are there
            while (freeStudents.Count > 0)
            {
                Group newGroup = new Group(groups.Count + 1, new List<Student>());
                while (freeStudents.Count != 0 && newGroup.Students.Count < 4)
                {
                    newGroup.Students.Add(freeStudents.ElementAt(0));
                    freeStudents.ElementAt(0).GroupID = newGroup.Id;
                    freeStudents.RemoveAt(0);
                }
                //add new group to groups list
                groups.Add(newGroup);
            }
            FileHandler.StoreGroups(groups);
            FileHandler.StoreStudents(students);
            MessageBox.Show("All free students have been added to old/new groups");
        }

        private void viewGroupMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewGrpMarksForm(groups).ShowDialog();
        }

        private void addGroupMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group grp = GetExistingGroup();

            if (grp == null)
                return;

            int marks;
            while(true)
            {
                string marksStr = Interaction.InputBox("Enter marks for the group: ", "Group Marks", "Default Text");

                if(marksStr == "Default Text")
                {
                    MessageBox.Show("Operation cancelled!");
                    return;
                }

                if (!int.TryParse(marksStr, out marks))
                    MessageBox.Show("Invalid input for marks!!");
                else
                    break;
            }

            grp.Marks = marks;

            for(int i=0; i<grp.Students.Count;i++)
            {
                int sMarks;
                while (true)
                {
                    string sMarksStr = Interaction.InputBox($"Enter marks for student {i + 1} the group: ", "Student Marks", "Default Text");
                    if (sMarksStr == "Default Text")
                    {
                        MessageBox.Show("Operation cancelled!");
                        return;
                    }

                    if (!int.TryParse(sMarksStr, out sMarks))
                        MessageBox.Show("Invalid input for marks!!");
                    else
                        break;
                }
                grp.Students[i].Marks = sMarks;
            }

            FileHandler.StoreGroups(groups);
            MessageBox.Show("Marks have been recorded for the group successfully");
        }
    }
}