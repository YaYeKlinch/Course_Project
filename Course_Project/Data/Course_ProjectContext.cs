using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Course_Project.Models;

namespace Course_Project.Data
{
    public class Course_ProjectContext : DbContext
    {
        public Course_ProjectContext (DbContextOptions<Course_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Course_Project.Models.Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().ToTable("Student");

        }

    }
}
