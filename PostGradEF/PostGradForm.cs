using ClassLib;
using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PostGradForms
{
    public partial class PostGradForm : Form
    {
        public PostGradForm()
        {
            InitializeComponent();
        }

        private void PostGradForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(studentFirstName.Text.Length > 0 && studentLastName.Text.Length > 0)
            {
                using (var context = new PostGradDbContext())
                {
                    context.Students.Add(new Student() { FirstName = studentFirstName.Text, LastName = studentLastName.Text });
                    context.SaveChanges();
                }
            }
        }

        private void createProfessorButton_Click(object sender, EventArgs e)
        {
            if (professorFirstName.Text.Length > 0 && professorLastName.Text.Length > 0)
            {
                using (var context = new PostGradDbContext())
                {
                    context.Professors.Add(new Professor() { FirstName = professorFirstName.Text, LastName = professorLastName.Text });
                    context.SaveChanges();
                }
            }
        }
    }
}
