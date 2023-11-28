namespace CMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToExistingGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToNewGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkAssignStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGroupsWithStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByGroupIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByStudentLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGroupMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.marksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.importStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // importStudentsToolStripMenuItem
            // 
            this.importStudentsToolStripMenuItem.Name = "importStudentsToolStripMenuItem";
            this.importStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.importStudentsToolStripMenuItem.Text = "Import Students";
            this.importStudentsToolStripMenuItem.Click += new System.EventHandler(this.importStudentsToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToExistingGroupToolStripMenuItem,
            this.addStudentToNewGroupToolStripMenuItem,
            this.bulkAssignStudentsToolStripMenuItem,
            this.showGroupsWithStudentsToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // addStudentToExistingGroupToolStripMenuItem
            // 
            this.addStudentToExistingGroupToolStripMenuItem.Name = "addStudentToExistingGroupToolStripMenuItem";
            this.addStudentToExistingGroupToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addStudentToExistingGroupToolStripMenuItem.Text = "Add Student to existing Group";
            this.addStudentToExistingGroupToolStripMenuItem.Click += new System.EventHandler(this.addStudentToExistingGroupToolStripMenuItem_Click);
            // 
            // addStudentToNewGroupToolStripMenuItem
            // 
            this.addStudentToNewGroupToolStripMenuItem.Name = "addStudentToNewGroupToolStripMenuItem";
            this.addStudentToNewGroupToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addStudentToNewGroupToolStripMenuItem.Text = "Add Student to new Group";
            this.addStudentToNewGroupToolStripMenuItem.Click += new System.EventHandler(this.addStudentToNewGroupToolStripMenuItem_Click);
            // 
            // bulkAssignStudentsToolStripMenuItem
            // 
            this.bulkAssignStudentsToolStripMenuItem.Name = "bulkAssignStudentsToolStripMenuItem";
            this.bulkAssignStudentsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.bulkAssignStudentsToolStripMenuItem.Text = "Bulk assign Students";
            this.bulkAssignStudentsToolStripMenuItem.Click += new System.EventHandler(this.bulkAssignStudentsToolStripMenuItem_Click);
            // 
            // showGroupsWithStudentsToolStripMenuItem
            // 
            this.showGroupsWithStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByGroupIdToolStripMenuItem,
            this.sortByStudentLastNameToolStripMenuItem});
            this.showGroupsWithStudentsToolStripMenuItem.Name = "showGroupsWithStudentsToolStripMenuItem";
            this.showGroupsWithStudentsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.showGroupsWithStudentsToolStripMenuItem.Text = "View Group Memberships";
            // 
            // sortByGroupIdToolStripMenuItem
            // 
            this.sortByGroupIdToolStripMenuItem.Name = "sortByGroupIdToolStripMenuItem";
            this.sortByGroupIdToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sortByGroupIdToolStripMenuItem.Text = "Sort by Group Id";
            this.sortByGroupIdToolStripMenuItem.Click += new System.EventHandler(this.sortByGroupIdToolStripMenuItem_Click);
            // 
            // sortByStudentLastNameToolStripMenuItem
            // 
            this.sortByStudentLastNameToolStripMenuItem.Name = "sortByStudentLastNameToolStripMenuItem";
            this.sortByStudentLastNameToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sortByStudentLastNameToolStripMenuItem.Text = "Sort By Student Last Name";
            this.sortByStudentLastNameToolStripMenuItem.Click += new System.EventHandler(this.sortByStudentLastNameToolStripMenuItem_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGroupMarksToolStripMenuItem,
            this.addGroupMarksToolStripMenuItem});
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.marksToolStripMenuItem.Text = "Marks";
            // 
            // viewGroupMarksToolStripMenuItem
            // 
            this.viewGroupMarksToolStripMenuItem.Name = "viewGroupMarksToolStripMenuItem";
            this.viewGroupMarksToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewGroupMarksToolStripMenuItem.Text = "View Group Marks";
            this.viewGroupMarksToolStripMenuItem.Click += new System.EventHandler(this.viewGroupMarksToolStripMenuItem_Click);
            // 
            // addGroupMarksToolStripMenuItem
            // 
            this.addGroupMarksToolStripMenuItem.Name = "addGroupMarksToolStripMenuItem";
            this.addGroupMarksToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addGroupMarksToolStripMenuItem.Text = "Add Group Marks";
            this.addGroupMarksToolStripMenuItem.Click += new System.EventHandler(this.addGroupMarksToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem importStudentsToolStripMenuItem;
        private ToolStripMenuItem groupsToolStripMenuItem;
        private ToolStripMenuItem addStudentToExistingGroupToolStripMenuItem;
        private ToolStripMenuItem addStudentToNewGroupToolStripMenuItem;
        private ToolStripMenuItem bulkAssignStudentsToolStripMenuItem;
        private ToolStripMenuItem marksToolStripMenuItem;
        private ToolStripMenuItem viewGroupMarksToolStripMenuItem;
        private ToolStripMenuItem addGroupMarksToolStripMenuItem;
        private ToolStripMenuItem showGroupsWithStudentsToolStripMenuItem;
        private ToolStripMenuItem sortByGroupIdToolStripMenuItem;
        private ToolStripMenuItem sortByStudentLastNameToolStripMenuItem;
    }
}