﻿// <auto-generated />
using Day6task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Day6task.Migrations
{
    [DbContext(typeof(Centerdbcontext))]
    partial class CenterdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Day6task.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<double>("degree")
                        .HasColumnType("float");

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<double>("mindegree")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Isdeleted = false,
                            degree = 40.0,
                            departmentid = 1,
                            mindegree = 60.0,
                            name = "C#"
                        },
                        new
                        {
                            id = 2,
                            Isdeleted = false,
                            degree = 30.0,
                            departmentid = 1,
                            mindegree = 40.0,
                            name = "SQL"
                        },
                        new
                        {
                            id = 3,
                            Isdeleted = false,
                            degree = 60.0,
                            departmentid = 1,
                            mindegree = 80.0,
                            name = "MCV"
                        },
                        new
                        {
                            id = 4,
                            Isdeleted = false,
                            degree = 40.0,
                            departmentid = 2,
                            mindegree = 60.0,
                            name = "Docker"
                        },
                        new
                        {
                            id = 5,
                            Isdeleted = false,
                            degree = 30.0,
                            departmentid = 2,
                            mindegree = 40.0,
                            name = "Kubernets"
                        },
                        new
                        {
                            id = 6,
                            Isdeleted = false,
                            degree = 60.0,
                            departmentid = 2,
                            mindegree = 80.0,
                            name = "Ansible"
                        },
                        new
                        {
                            id = 7,
                            Isdeleted = false,
                            degree = 40.0,
                            departmentid = 3,
                            mindegree = 60.0,
                            name = "deep learning"
                        },
                        new
                        {
                            id = 8,
                            Isdeleted = false,
                            degree = 30.0,
                            departmentid = 3,
                            mindegree = 40.0,
                            name = "data structures"
                        },
                        new
                        {
                            id = 9,
                            Isdeleted = false,
                            degree = 60.0,
                            departmentid = 3,
                            mindegree = 80.0,
                            name = "python"
                        });
                });

            modelBuilder.Entity("Day6task.Models.CourseResult", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.Property<double>("degree")
                        .HasColumnType("float");

                    b.Property<int>("traineeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("courseid");

                    b.HasIndex("traineeid");

                    b.ToTable("courseResults");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Isdeleted = false,
                            courseid = 1,
                            degree = 20.0,
                            traineeid = 1
                        },
                        new
                        {
                            id = 2,
                            Isdeleted = false,
                            courseid = 1,
                            degree = 59.0,
                            traineeid = 2
                        },
                        new
                        {
                            id = 3,
                            Isdeleted = false,
                            courseid = 1,
                            degree = 44.0,
                            traineeid = 3
                        },
                        new
                        {
                            id = 4,
                            Isdeleted = false,
                            courseid = 2,
                            degree = 20.0,
                            traineeid = 1
                        },
                        new
                        {
                            id = 5,
                            Isdeleted = false,
                            courseid = 2,
                            degree = 25.0,
                            traineeid = 2
                        },
                        new
                        {
                            id = 6,
                            Isdeleted = false,
                            courseid = 2,
                            degree = 39.0,
                            traineeid = 3
                        },
                        new
                        {
                            id = 7,
                            Isdeleted = false,
                            courseid = 3,
                            degree = 70.0,
                            traineeid = 1
                        },
                        new
                        {
                            id = 8,
                            Isdeleted = false,
                            courseid = 3,
                            degree = 30.0,
                            traineeid = 2
                        },
                        new
                        {
                            id = 9,
                            Isdeleted = false,
                            courseid = 3,
                            degree = 60.0,
                            traineeid = 3
                        },
                        new
                        {
                            id = 10,
                            Isdeleted = false,
                            courseid = 4,
                            degree = 20.0,
                            traineeid = 4
                        },
                        new
                        {
                            id = 11,
                            Isdeleted = false,
                            courseid = 4,
                            degree = 45.0,
                            traineeid = 5
                        },
                        new
                        {
                            id = 12,
                            Isdeleted = false,
                            courseid = 5,
                            degree = 35.0,
                            traineeid = 4
                        },
                        new
                        {
                            id = 13,
                            Isdeleted = false,
                            courseid = 5,
                            degree = 20.0,
                            traineeid = 5
                        },
                        new
                        {
                            id = 14,
                            Isdeleted = false,
                            courseid = 6,
                            degree = 76.0,
                            traineeid = 4
                        },
                        new
                        {
                            id = 15,
                            Isdeleted = false,
                            courseid = 6,
                            degree = 45.0,
                            traineeid = 5
                        },
                        new
                        {
                            id = 16,
                            Isdeleted = false,
                            courseid = 7,
                            degree = 20.0,
                            traineeid = 6
                        },
                        new
                        {
                            id = 17,
                            Isdeleted = false,
                            courseid = 7,
                            degree = 59.0,
                            traineeid = 7
                        },
                        new
                        {
                            id = 18,
                            Isdeleted = false,
                            courseid = 7,
                            degree = 44.0,
                            traineeid = 8
                        },
                        new
                        {
                            id = 19,
                            Isdeleted = false,
                            courseid = 8,
                            degree = 20.0,
                            traineeid = 6
                        },
                        new
                        {
                            id = 20,
                            Isdeleted = false,
                            courseid = 8,
                            degree = 25.0,
                            traineeid = 7
                        },
                        new
                        {
                            id = 21,
                            Isdeleted = false,
                            courseid = 8,
                            degree = 39.0,
                            traineeid = 8
                        },
                        new
                        {
                            id = 22,
                            Isdeleted = false,
                            courseid = 9,
                            degree = 70.0,
                            traineeid = 6
                        },
                        new
                        {
                            id = 23,
                            Isdeleted = false,
                            courseid = 9,
                            degree = 30.0,
                            traineeid = 7
                        },
                        new
                        {
                            id = 24,
                            Isdeleted = false,
                            courseid = 9,
                            degree = 60.0,
                            traineeid = 8
                        });
                });

            modelBuilder.Entity("Day6task.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Isdeleted = false,
                            Name = "dotnet",
                            manager = "rania mostafa"
                        },
                        new
                        {
                            id = 2,
                            Isdeleted = false,
                            Name = "devops",
                            manager = "ahmed mohsen"
                        },
                        new
                        {
                            id = 3,
                            Isdeleted = false,
                            Name = "AI",
                            manager = "yousef menesi"
                        });
                });

            modelBuilder.Entity("Day6task.Models.Instructor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("courseid");

                    b.HasIndex("departmentid");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Isdeleted = false,
                            Name = "mohamed saber",
                            address = "Sedi_Beshr Alex",
                            courseid = 1,
                            departmentid = 1,
                            imageurl = "1.jpg"
                        },
                        new
                        {
                            id = 2,
                            Isdeleted = false,
                            Name = "mohamed hagar",
                            address = " Elsheikh zayed",
                            courseid = 2,
                            departmentid = 1,
                            imageurl = "2.jpg"
                        },
                        new
                        {
                            id = 3,
                            Isdeleted = false,
                            Name = "wael tabaey",
                            address = "alzahraa - Nasr city",
                            courseid = 3,
                            departmentid = 1,
                            imageurl = "3.jpg"
                        },
                        new
                        {
                            id = 4,
                            Isdeleted = false,
                            Name = "nada sadek",
                            address = "Albahr al aazam",
                            courseid = 4,
                            departmentid = 2,
                            imageurl = "4.jpg"
                        },
                        new
                        {
                            id = 5,
                            Isdeleted = false,
                            Name = "mahmoud mohamed",
                            address = "Elgamalia",
                            courseid = 5,
                            departmentid = 2,
                            imageurl = "5.jpg"
                        },
                        new
                        {
                            id = 6,
                            Isdeleted = false,
                            Name = "yasmeen nael",
                            address = "Sedi_Beshr Alex",
                            courseid = 6,
                            departmentid = 2,
                            imageurl = "6.jpg"
                        },
                        new
                        {
                            id = 7,
                            Isdeleted = false,
                            Name = "Ali Elgayar",
                            address = "Albahr al aazam",
                            courseid = 7,
                            departmentid = 3,
                            imageurl = "7.jpg"
                        },
                        new
                        {
                            id = 8,
                            Isdeleted = false,
                            Name = "khaled hanafy",
                            address = "Sedi_Beshr Alex",
                            courseid = 8,
                            departmentid = 3,
                            imageurl = "8.jpg"
                        },
                        new
                        {
                            id = 9,
                            Isdeleted = false,
                            Name = "mohamed nassem",
                            address = "Albahr al aazam",
                            courseid = 9,
                            departmentid = 3,
                            imageurl = "9.jpg"
                        });
                });

            modelBuilder.Entity("Day6task.Models.Trainee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<double>("grade")
                        .HasColumnType("float");

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("Trainees");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Isdeleted = false,
                            Name = "adel hamdy ",
                            address = "talkha",
                            departmentid = 1,
                            grade = 4.5,
                            imageurl = "10.jpg"
                        },
                        new
                        {
                            id = 2,
                            Isdeleted = false,
                            Name = "hussien kamel ",
                            address = "talkha",
                            departmentid = 1,
                            grade = 4.0999999999999996,
                            imageurl = "11.jpg"
                        },
                        new
                        {
                            id = 3,
                            Isdeleted = false,
                            Name = "tarek mohamed ",
                            address = "talkha",
                            departmentid = 1,
                            grade = 2.2999999999999998,
                            imageurl = "12.jpg"
                        },
                        new
                        {
                            id = 4,
                            Isdeleted = false,
                            Name = "omar nasif ",
                            address = "talkha",
                            departmentid = 2,
                            grade = 2.5,
                            imageurl = "13.jpg"
                        },
                        new
                        {
                            id = 5,
                            Isdeleted = false,
                            Name = "layla nazmy ",
                            address = "talkha",
                            departmentid = 2,
                            grade = 1.3,
                            imageurl = "14.jpg"
                        },
                        new
                        {
                            id = 6,
                            Isdeleted = false,
                            Name = "kadry mohamed ",
                            address = "talkha",
                            departmentid = 3,
                            grade = 3.6000000000000001,
                            imageurl = "15.jpg"
                        },
                        new
                        {
                            id = 7,
                            Isdeleted = false,
                            Name = "adel tarek ",
                            address = "talkha",
                            departmentid = 3,
                            grade = 4.7000000000000002,
                            imageurl = "16.jpg"
                        },
                        new
                        {
                            id = 8,
                            Isdeleted = false,
                            Name = "dena tawakol ",
                            address = "talkha",
                            departmentid = 3,
                            grade = 4.9000000000000004,
                            imageurl = "17.jpg"
                        });
                });

            modelBuilder.Entity("Day6task.Models.Course", b =>
                {
                    b.HasOne("Day6task.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Day6task.Models.CourseResult", b =>
                {
                    b.HasOne("Day6task.Models.Course", "Course")
                        .WithMany("CourseResults")
                        .HasForeignKey("courseid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Day6task.Models.Trainee", "Trainee")
                        .WithMany("courseresults")
                        .HasForeignKey("traineeid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("Day6task.Models.Instructor", b =>
                {
                    b.HasOne("Day6task.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("courseid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Day6task.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Day6task.Models.Trainee", b =>
                {
                    b.HasOne("Day6task.Models.Department", "Department")
                        .WithMany("Traines")
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Day6task.Models.Course", b =>
                {
                    b.Navigation("CourseResults");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Day6task.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Traines");
                });

            modelBuilder.Entity("Day6task.Models.Trainee", b =>
                {
                    b.Navigation("courseresults");
                });
#pragma warning restore 612, 618
        }
    }
}
