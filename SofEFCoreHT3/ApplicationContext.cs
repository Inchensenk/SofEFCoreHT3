using EF_HW2.Entities;
using EF_HW2.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SofEFCoreHT3.Entities;
using SofEFCoreHT3.Entities.Configurations;
using System;
using System.IO;
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
        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = c-dev-01;Database=StudentsHT3;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Data Source=c-dev-01; Database=StudentsHT3; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Trace);//запись лога в файл
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
            OnMarksCreated(modelBuilder);
            OnSubjectsCreated(modelBuilder);
            OnStudentsCreated(modelBuilder);
            //OnSubjectConfigurations(modelBuilder);
            //OnCardsConfigurations(modelBuilder);
            //OnStudentsConfigurations(modelBuilder);
        }


        protected void OnMarksCreated(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 1, MarkValue = 7 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 2, MarkValue = 8 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 3, MarkValue = 3 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 4, MarkValue = 10 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 5, MarkValue = 12 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 6, MarkValue = 10 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 7, MarkValue = 5 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 8, MarkValue = 9 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 9, MarkValue = 12 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 10, MarkValue = 7 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 11, MarkValue = 8 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 12, MarkValue = 6 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 13, MarkValue = 10 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 14, MarkValue = 11 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 15, MarkValue = 1 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 16, MarkValue = 10 });
            modelBuilder.Entity<Mark>().HasData(new Mark { Id = 17, MarkValue = 8 });

            
        }

        protected void OnSubjectsCreated(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 1, SubjectName = "Maths" });
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 2, SubjectName = "Informatics" });
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 3, SubjectName = "Algorithms and data structure" });
        }

        protected void OnStudentsCreated(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Elen", LastName = "Storm", BirthDate = DateTime.Parse("1990-03-15"), PhoneNumber = "+7(929)229-29-29" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Mark", LastName = "Tven", BirthDate = DateTime.Parse("1988-07-13"), PhoneNumber = "+7(919)285-87-33" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Anton", LastName = "Antonov", BirthDate = DateTime.Parse("2000-09-26"), PhoneNumber = "+7(918)335-35-33" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, FirstName = "Vikram", LastName = "Smirnov", BirthDate = DateTime.Parse("2001-06-30"), PhoneNumber = "+7(919)288-89-93" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, FirstName = "Arseniy", LastName = "Papka", BirthDate = DateTime.Parse("2005-02-23"), PhoneNumber = "+7(919)329-21-99" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 6, FirstName = "Volodya", LastName = "Doe", BirthDate = DateTime.Parse("2003-12-14"), PhoneNumber = "+7(919)429-33-33" });
        }

        //protected void OnSubjectConfigurations(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Subject>().HasIndex(s=>s.SubjectName).IsUnique();
        //}

        //public void OnCardsConfigurations(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Card>().HasIndex(c => c.SerialNumber).IsUnique();
        //}

        //public void OnStudentsConfigurations(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasIndex(s => s.PhoneNumber).IsUnique();
        //}


        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
