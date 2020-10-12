using ClassLib;
using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGradForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // SeedDb();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PostGradForm());
        }

        public static void SeedDb()
        {
            using (var context = new PostGradDbContext())
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();

                var g = new Student() { FirstName = "Gøran", LastName = "the Student" };
                var a = new Student() { FirstName = "Anakin", LastName = "Skywalker" };
                var s = new Professor() { FirstName = "Sean", LastName = "the Professor" };
                var c = new Course() { Topic = "Operating Light Sabers", Professor = s};

                var sc1 = new StudentCourse { Student = g, Course = c };
                var sc2 = new StudentCourse { Student = a, Course = c };

                context.Students.Add(g);
                context.Students.Add(a);
                context.Professors.Add(s);
                context.Courses.Add(c);
                context.StudentCourses.Add(sc1);
                context.StudentCourses.Add(sc2);
                context.SaveChanges();
            }
        }
    }
}
