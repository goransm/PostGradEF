namespace PostGradForms
{
    partial class PostGradForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentFirstName = new System.Windows.Forms.TextBox();
            this.studentLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.createProfessorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.professorLastName = new System.Windows.Forms.TextBox();
            this.professorFirstName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createStudentButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.studentLastName);
            this.tabPage1.Controls.Add(this.studentFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.professorFirstName);
            this.tabPage2.Controls.Add(this.professorLastName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.createProfessorButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Professor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // studentFirstName
            // 
            this.studentFirstName.Location = new System.Drawing.Point(17, 57);
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.Size = new System.Drawing.Size(200, 23);
            this.studentFirstName.TabIndex = 0;
            // 
            // studentLastName
            // 
            this.studentLastName.Location = new System.Drawing.Point(17, 125);
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Size = new System.Drawing.Size(200, 23);
            this.studentLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // createStudentButton
            // 
            this.createStudentButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.createStudentButton.Location = new System.Drawing.Point(17, 185);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(200, 32);
            this.createStudentButton.TabIndex = 4;
            this.createStudentButton.Text = "CREATE";
            this.createStudentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createStudentButton.UseVisualStyleBackColor = false;
            this.createStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createProfessorButton
            // 
            this.createProfessorButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.createProfessorButton.Location = new System.Drawing.Point(20, 189);
            this.createProfessorButton.Name = "createProfessorButton";
            this.createProfessorButton.Size = new System.Drawing.Size(200, 32);
            this.createProfessorButton.TabIndex = 4;
            this.createProfessorButton.Text = "CREATE";
            this.createProfessorButton.UseVisualStyleBackColor = false;
            this.createProfessorButton.Click += new System.EventHandler(this.createProfessorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "First name";
            // 
            // professorLastName
            // 
            this.professorLastName.Location = new System.Drawing.Point(20, 129);
            this.professorLastName.Name = "professorLastName";
            this.professorLastName.Size = new System.Drawing.Size(200, 23);
            this.professorLastName.TabIndex = 1;
            // 
            // professorFirstName
            // 
            this.professorFirstName.Location = new System.Drawing.Point(20, 61);
            this.professorFirstName.Name = "professorFirstName";
            this.professorFirstName.Size = new System.Drawing.Size(200, 23);
            this.professorFirstName.TabIndex = 0;
            // 
            // PostGradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PostGradForm";
            this.Text = "PostGradForm";
            this.Load += new System.EventHandler(this.PostGradForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentLastName;
        private System.Windows.Forms.TextBox studentFirstName;
        private System.Windows.Forms.TextBox professorFirstName;
        private System.Windows.Forms.TextBox professorLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createProfessorButton;
    }
}