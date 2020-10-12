using ClassLib;
using ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostGradForms
{
    public partial class PostGradForm : Form
    {
        //private IList<Course> courses { get; set; }

        public PostGradForm()
        {
            InitializeComponent();
            UpdateCourses();
            UpdateStudents();
            UpdateProfessors();
            courseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            professorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            courseList.MultiSelect = false;
            studentGridView.MultiSelect = false;
            professorGridView.MultiSelect = false;
            courseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            studentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            professorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void UpdateCourses()
        {
            using (var context = new PostGradDbContext())
            {

                var courses = context.Courses.Take(20).Include(c => c.Professor).Select(c => new { Id = c.Id, Topic = c.Topic, Teacher = (c.Professor != null ? c.Professor.FullName : "N/A") }).ToList();
                courseList.DataSource = courses;
            }
        }

        private void UpdateStudents()
        {
            using (var context = new PostGradDbContext())
            {

                var students = context.Students.Take(20).Include(s => s.Professor).Select(s => new {Id = s.Id, Name = s.FullName, Professor = (s.Professor != null ? s.Professor.FullName : "not assigned") }).ToList();
                studentGridView.DataSource = students;
            }
        }

        private void UpdateProfessors()
        {
            using (var context = new PostGradDbContext())
            {

                var professors = context.Professors.Take(20).Select(p => new {Id = p.Id, Name = p.FullName } ).ToList();
                professorGridView.DataSource = professors;
            }
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
                    UpdateStudents();
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
                    UpdateProfessors();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var courseTopic = createCourseInput.Text;
            if (courseTopic.Length > 0)
            {
                using (var context = new PostGradDbContext())
                {
                    context.Courses.Add(new Course() { Topic = courseTopic });
                    createCourseInput.Text = "";
                    context.SaveChanges();
                    UpdateCourses();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (courseList.SelectedRows.Count == 1)
            {
                using (var context = new PostGradDbContext())
                {
                    var courseId = (int)courseList.SelectedRows[0].Cells["Id"].Value;
                    var course = context.Courses.SingleOrDefault(c => c.Id == courseId);
                    //var studentCourse = context.StudentCourses.SingleOrDefault(c => c.CourseId == courseId);
                    course.Topic = createCourseInput.Text;
                    context.Courses.Update(course);
                    //context.StudentCourses.Remove(studentCourse);

                    context.SaveChanges();
                    UpdateCourses();
                }
            }
        }

        private void setCourseProfessor_Click(object sender, EventArgs e)
        {
            if (courseList.SelectedRows.Count == 1 && professorGridView.SelectedRows.Count == 1)
            {
                var courseId = (int)courseList.SelectedRows[0].Cells["Id"].Value;
                var professorId = (int)professorGridView.SelectedRows[0].Cells["Id"].Value;
                using (var context = new PostGradDbContext())
                {
                    var selectedCourse = context.Courses.Find(courseId);
                    selectedCourse.ProfessorId = professorId;
                    context.SaveChanges();
                    UpdateCourses();
                }
            }
        }

        private void addStudentToCourse_Click(object sender, EventArgs e)
        {
            if (courseList.SelectedRows.Count == 1 && studentGridView.SelectedRows.Count == 1)
            {
                var courseId = (int)courseList.SelectedRows[0].Cells["Id"].Value;
                var studentId = (int)studentGridView.SelectedRows[0].Cells["Id"].Value;
                using (var context = new PostGradDbContext())
                {
                    var studentCourse = new StudentCourse() { CourseId = courseId, StudentId = studentId };
                    context.StudentCourses.Add(studentCourse);
                    context.SaveChanges();
                }
            }
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            if (courseList.SelectedRows.Count == 1)
            {
                using (var context = new PostGradDbContext())
                {
                    var courseId = (int)courseList.SelectedRows[0].Cells["Id"].Value;
                    var course = context.Courses.SingleOrDefault(c => c.Id == courseId);
                    //var studentCourse = context.StudentCourses.SingleOrDefault(c => c.CourseId == courseId);
                    context.Courses.Remove(course);
                    //context.StudentCourses.Remove(studentCourse);
                    
                    context.SaveChanges();
                    UpdateCourses();
                }
            }
        }
    }
}
