using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib.Models
{
    public class PostGradDbContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PC7414\\SQLEXPRESS;Initial Catalog=PostGradDB;Integrated Security=True;");
        }

    }
}
