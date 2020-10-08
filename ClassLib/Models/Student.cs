using System;
using System.Reflection.Metadata.Ecma335;

namespace ClassLib
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
