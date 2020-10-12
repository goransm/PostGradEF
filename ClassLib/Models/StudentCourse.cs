using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib.Models
{
    public class StudentCourse
    {
        // Foreign key, linking to a student in the database
        public int StudentId { get; set; }

        // Navigation property
        public Student Student { get; set; }

        // Foreign key, linking to a course in the database
        public int CourseId { get; set; }

        // Navigation property
        public Course Course { get; set; }
    }
}
