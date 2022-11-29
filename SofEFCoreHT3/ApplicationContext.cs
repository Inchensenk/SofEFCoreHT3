using EF_HW2.Entities;
using EF_HW2.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofEFCoreHT3
{
    public class ApplicationContext : DbContext
    {
        private readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);

        public DbSet<Card> Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=s-dev-01;Database=StudentsDB;Trusted_Connection=True;");

            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Trace);//запись лога в файл
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
