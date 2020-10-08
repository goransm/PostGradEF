using System;
using System.Reflection.Metadata.Ecma335;

namespace ClassLib
{
    public class Professor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student PostGradStudent { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
