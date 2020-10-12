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
            this.createStudentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentLastName = new System.Windows.Forms.TextBox();
            this.studentFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.professorFirstName = new System.Windows.Forms.TextBox();
            this.professorLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createProfessorButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.professorListLabel = new System.Windows.Forms.Label();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.setCourseProfessor = new System.Windows.Forms.Button();
            this.addStudentToCourse = new System.Windows.Forms.Button();
            this.professorGridView = new System.Windows.Forms.DataGridView();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.deleteCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.courseList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.createCourseInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
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
            // studentLastName
            // 
            this.studentLastName.Location = new System.Drawing.Point(17, 125);
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Size = new System.Drawing.Size(200, 23);
            this.studentLastName.TabIndex = 1;
            // 
            // studentFirstName
            // 
            this.studentFirstName.Location = new System.Drawing.Point(17, 57);
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.Size = new System.Drawing.Size(200, 23);
            this.studentFirstName.TabIndex = 0;
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
            // professorFirstName
            // 
            this.professorFirstName.Location = new System.Drawing.Point(20, 61);
            this.professorFirstName.Name = "professorFirstName";
            this.professorFirstName.Size = new System.Drawing.Size(200, 23);
            this.professorFirstName.TabIndex = 0;
            // 
            // professorLastName
            // 
            this.professorLastName.Location = new System.Drawing.Point(20, 129);
            this.professorLastName.Name = "professorLastName";
            this.professorLastName.Size = new System.Drawing.Size(200, 23);
            this.professorLastName.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.professorListLabel);
            this.tabPage3.Controls.Add(this.studentListLabel);
            this.tabPage3.Controls.Add(this.coursesLabel);
            this.tabPage3.Controls.Add(this.setCourseProfessor);
            this.tabPage3.Controls.Add(this.addStudentToCourse);
            this.tabPage3.Controls.Add(this.professorGridView);
            this.tabPage3.Controls.Add(this.studentGridView);
            this.tabPage3.Controls.Add(this.deleteCourse);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.courseList);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.createCourseInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Course";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // professorListLabel
            // 
            this.professorListLabel.AutoSize = true;
            this.professorListLabel.Location = new System.Drawing.Point(574, 108);
            this.professorListLabel.Name = "professorListLabel";
            this.professorListLabel.Size = new System.Drawing.Size(61, 15);
            this.professorListLabel.TabIndex = 13;
            this.professorListLabel.Text = "Professors";
            // 
            // studentListLabel
            // 
            this.studentListLabel.AutoSize = true;
            this.studentListLabel.Location = new System.Drawing.Point(403, 108);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(53, 15);
            this.studentListLabel.TabIndex = 12;
            this.studentListLabel.Text = "Students";
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Location = new System.Drawing.Point(15, 108);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(91, 15);
            this.coursesLabel.TabIndex = 11;
            this.coursesLabel.Text = "Existing courses";
            // 
            // setCourseProfessor
            // 
            this.setCourseProfessor.Location = new System.Drawing.Point(574, 365);
            this.setCourseProfessor.Name = "setCourseProfessor";
            this.setCourseProfessor.Size = new System.Drawing.Size(152, 23);
            this.setCourseProfessor.TabIndex = 10;
            this.setCourseProfessor.Text = "Set professor";
            this.setCourseProfessor.UseVisualStyleBackColor = true;
            this.setCourseProfessor.Click += new System.EventHandler(this.setCourseProfessor_Click);
            // 
            // addStudentToCourse
            // 
            this.addStudentToCourse.Location = new System.Drawing.Point(403, 365);
            this.addStudentToCourse.Name = "addStudentToCourse";
            this.addStudentToCourse.Size = new System.Drawing.Size(155, 23);
            this.addStudentToCourse.TabIndex = 9;
            this.addStudentToCourse.Text = "Add student";
            this.addStudentToCourse.UseVisualStyleBackColor = true;
            this.addStudentToCourse.Click += new System.EventHandler(this.addStudentToCourse_Click);
            // 
            // professorGridView
            // 
            this.professorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorGridView.Location = new System.Drawing.Point(574, 126);
            this.professorGridView.Name = "professorGridView";
            this.professorGridView.Size = new System.Drawing.Size(152, 225);
            this.professorGridView.TabIndex = 8;
            this.professorGridView.Text = "dataGridView2";
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(403, 126);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(155, 225);
            this.studentGridView.TabIndex = 7;
            this.studentGridView.Text = "dataGridView2";
            // 
            // deleteCourse
            // 
            this.deleteCourse.BackColor = System.Drawing.Color.Firebrick;
            this.deleteCourse.ForeColor = System.Drawing.Color.Snow;
            this.deleteCourse.Location = new System.Drawing.Point(138, 365);
            this.deleteCourse.Name = "deleteCourse";
            this.deleteCourse.Size = new System.Drawing.Size(116, 23);
            this.deleteCourse.TabIndex = 6;
            this.deleteCourse.Text = "Delete course";
            this.deleteCourse.UseVisualStyleBackColor = false;
            this.deleteCourse.Click += new System.EventHandler(this.deleteCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update topic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // courseList
            // 
            this.courseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseList.Location = new System.Drawing.Point(15, 126);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(370, 225);
            this.courseList.TabIndex = 4;
            this.courseList.Text = "dataGridView1";
            this.courseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Courses";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(230, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course topic:";
            // 
            // createCourseInput
            // 
            this.createCourseInput.Location = new System.Drawing.Point(15, 66);
            this.createCourseInput.Name = "createCourseInput";
            this.createCourseInput.Size = new System.Drawing.Size(208, 23);
            this.createCourseInput.TabIndex = 0;
            // 
            // PostGradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "PostGradForm";
            this.Text = "PostGradForm";
            this.Load += new System.EventHandler(this.PostGradForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button deleteCourse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView courseList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox createCourseInput;
        private System.Windows.Forms.Button setCourseProfessor;
        private System.Windows.Forms.Button addStudentToCourse;
        private System.Windows.Forms.DataGridView professorGridView;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Label professorListLabel;
        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.Label coursesLabel;
    }
}