// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SofEFCoreHT3;

#nullable disable

namespace SofEFCoreHT3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardSubject", b =>
                {
                    b.Property<int>("CardsId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int");

                    b.HasKey("CardsId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("EF_HW2.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SerialNumber")
                        .IsUnique();

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("EF_HW2.Entities.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<double>("MarkValue")
                        .HasColumnType("float");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 0,
                            MarkValue = 7.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 2,
                            CardId = 0,
                            MarkValue = 8.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 3,
                            CardId = 0,
                            MarkValue = 3.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 4,
                            CardId = 0,
                            MarkValue = 10.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 5,
                            CardId = 0,
                            MarkValue = 12.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 6,
                            CardId = 0,
                            MarkValue = 10.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 7,
                            CardId = 0,
                            MarkValue = 5.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 8,
                            CardId = 0,
                            MarkValue = 9.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 9,
                            CardId = 0,
                            MarkValue = 12.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 10,
                            CardId = 0,
                            MarkValue = 7.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 11,
                            CardId = 0,
                            MarkValue = 8.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 12,
                            CardId = 0,
                            MarkValue = 6.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 13,
                            CardId = 0,
                            MarkValue = 10.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 14,
                            CardId = 0,
                            MarkValue = 11.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 15,
                            CardId = 0,
                            MarkValue = 1.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 16,
                            CardId = 0,
                            MarkValue = 10.0,
                            SubjectId = 0
                        },
                        new
                        {
                            Id = 17,
                            CardId = 0,
                            MarkValue = 8.0,
                            SubjectId = 0
                        });
                });

            modelBuilder.Entity("EF_HW2.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Elen",
                            LastName = "Storm",
                            PhoneNumber = "+7(929)229-29-29"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1988, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mark",
                            LastName = "Tven",
                            PhoneNumber = "+7(919)285-87-33"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anton",
                            LastName = "Antonov",
                            PhoneNumber = "+7(918)335-35-33"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2001, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vikram",
                            LastName = "Smirnov",
                            PhoneNumber = "+7(919)288-89-93"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2005, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Arseniy",
                            LastName = "Papka",
                            PhoneNumber = "+7(919)329-21-99"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2003, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Volodya",
                            LastName = "Doe",
                            PhoneNumber = "+7(919)429-33-33"
                        });
                });

            modelBuilder.Entity("EF_HW2.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 0,
                            SubjectName = "Maths"
                        },
                        new
                        {
                            Id = 2,
                            CardId = 0,
                            SubjectName = "Informatics"
                        },
                        new
                        {
                            Id = 3,
                            CardId = 0,
                            SubjectName = "Algorithms and data structure"
                        });
                });

            modelBuilder.Entity("CardSubject", b =>
                {
                    b.HasOne("EF_HW2.Entities.Card", null)
                        .WithMany()
                        .HasForeignKey("CardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_HW2.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_HW2.Entities.Card", b =>
                {
                    b.HasOne("EF_HW2.Entities.Student", "Student")
                        .WithOne("Card")
                        .HasForeignKey("EF_HW2.Entities.Card", "SerialNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EF_HW2.Entities.Mark", b =>
                {
                    b.HasOne("EF_HW2.Entities.Card", "Card")
                        .WithMany("Marks")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_HW2.Entities.Subject", "Subject")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("EF_HW2.Entities.Card", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("EF_HW2.Entities.Student", b =>
                {
                    b.Navigation("Card");
                });

            modelBuilder.Entity("EF_HW2.Entities.Subject", b =>
                {
                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}
