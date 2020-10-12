using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ClassLib.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // ProfessorId is the foreign key, linking the student to a professor in the database
        public int? ProfessorId { get; set; }

        // Navigation property - in this case it is a one-to-one relationship.
        public Professor Professor { get; set; }

        // This is the navigation property for a many-to-many relationship. The foreign keys are stored in the StudentCourse class.
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


    }
}
