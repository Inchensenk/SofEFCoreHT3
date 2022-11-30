﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SofEFCoreHT3;

#nullable disable

namespace SofEFCoreHT3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221130125750_AddSubjectNameInSubjectsTable")]
    partial class AddSubjectNameInSubjectsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("CardSubject");
                });

            modelBuilder.Entity("EF_HW2.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SerialNumber")
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

                    b.Property<double>("MarkValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MarkValue = 7.0
                        },
                        new
                        {
                            Id = 2,
                            MarkValue = 8.0
                        },
                        new
                        {
                            Id = 3,
                            MarkValue = 3.0
                        },
                        new
                        {
                            Id = 4,
                            MarkValue = 10.0
                        },
                        new
                        {
                            Id = 5,
                            MarkValue = 12.0
                        },
                        new
                        {
                            Id = 6,
                            MarkValue = 10.0
                        },
                        new
                        {
                            Id = 7,
                            MarkValue = 5.0
                        },
                        new
                        {
                            Id = 8,
                            MarkValue = 9.0
                        },
                        new
                        {
                            Id = 9,
                            MarkValue = 12.0
                        },
                        new
                        {
                            Id = 10,
                            MarkValue = 7.0
                        },
                        new
                        {
                            Id = 11,
                            MarkValue = 8.0
                        },
                        new
                        {
                            Id = 12,
                            MarkValue = 6.0
                        },
                        new
                        {
                            Id = 13,
                            MarkValue = 10.0
                        },
                        new
                        {
                            Id = 14,
                            MarkValue = 11.0
                        },
                        new
                        {
                            Id = 15,
                            MarkValue = 1.0
                        },
                        new
                        {
                            Id = 16,
                            MarkValue = 10.0
                        },
                        new
                        {
                            Id = 17,
                            MarkValue = 8.0
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_HW2.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubjectName = "Maths"
                        },
                        new
                        {
                            Id = 2,
                            SubjectName = "Informatics"
                        },
                        new
                        {
                            Id = 3,
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

            modelBuilder.Entity("EF_HW2.Entities.Student", b =>
                {
                    b.Navigation("Card");
                });
#pragma warning restore 612, 618
        }
    }
}