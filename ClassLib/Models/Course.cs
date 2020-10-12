using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        // Foreign key, linking the course to a professor in the database
        public int? ProfessorId { get; set; }

        // Navigation property
        public Professor Professor { get; set; }

        // Navigation property for a many-to-many relationship between student and course. 
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
