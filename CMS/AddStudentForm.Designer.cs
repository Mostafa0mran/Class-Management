namespace CMS
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.canclBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Student Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 109);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(207, 109);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(121, 25);
            this.idBox.TabIndex = 7;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(207, 155);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(121, 25);
            this.fnameBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 159);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(207, 202);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(121, 25);
            this.lnameBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(94, 206);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(207, 250);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(121, 25);
            this.emailBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(94, 254);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(219, 339);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 37);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add Student";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // canclBtn
            // 
            this.canclBtn.Location = new System.Drawing.Point(104, 339);
            this.canclBtn.Name = "canclBtn";
            this.canclBtn.Size = new System.Drawing.Size(109, 37);
            this.canclBtn.TabIndex = 15;
            this.canclBtn.Text = "Close";
            this.canclBtn.UseVisualStyleBackColor = true;
            this.canclBtn.Click += new System.EventHandler(this.canclBtn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.canclBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox idBox;
        private TextBox fnameBox;
        private Label label3;
        private TextBox lnameBox;
        private Label label4;
        private TextBox emailBox;
        private Label label5;
        private Button addBtn;
        private Button canclBtn;
    }
}