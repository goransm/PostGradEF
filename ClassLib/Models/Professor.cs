using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ClassLib.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navgation property for the one-to-one relationship between student and professor.
        public Student PostGradStudent { get; set; }

        //Navigation property for a one-to-many relationship between professor and course. 
        public ICollection<Course> Courses { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
