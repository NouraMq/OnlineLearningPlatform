using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.OnlineLearningPlatform.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.OnlineLearningPlatform.Context
{
    public class OnlineLearningDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "Server=localhost\\MSSQLSERVER06;Database=OnlineLearningDB;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(con);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite key for Cources
            modelBuilder.Entity<Cources>()
                .HasKey(oi => new { oi.Id, oi.StudentId });

            // Optional: configure relationships, constraints, etc.
        }

        public DbSet<Cources> cources { get; set; }
        public DbSet<Student> Student { get; set; }
        public object Students { get; internal set; }
    }
}