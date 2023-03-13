﻿// <auto-generated />
using System;
using ExamAPP;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamAPP.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230312190842_InitTables")]
    partial class InitTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamAPP.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeptNames")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Dept_Crs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<int?>("Ins_CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("departmentsId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Ins_CourseId");

                    b.HasIndex("departmentsId");

                    b.ToTable("dept_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("InsID")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int?>("coursesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("coursesId");

                    b.ToTable("ins_Courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<int>("InsID")
                        .HasColumnType("int");

                    b.Property<int?>("instructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("instructorId");

                    b.ToTable("ins_Departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("StudID")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentID");

                    b.ToTable("stud_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("departmentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ExamAPP.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("coursesId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("coursesId");

                    b.ToTable("topics");
                });

            modelBuilder.Entity("ExamAPP.Models.Dept_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Ins_Course", "Ins_Course")
                        .WithMany("dept_Crs")
                        .HasForeignKey("Ins_CourseId");

                    b.HasOne("ExamAPP.Models.Department", "departments")
                        .WithMany("dept_Crs")
                        .HasForeignKey("departmentsId");

                    b.Navigation("Ins_Course");

                    b.Navigation("departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.HasOne("ExamAPP.Models.Instructor", "Instructor")
                        .WithMany("Ins_Course")
                        .HasForeignKey("InstructorId");

                    b.HasOne("ExamAPP.Models.Course", "courses")
                        .WithMany("Ins_Course")
                        .HasForeignKey("coursesId");

                    b.Navigation("Instructor");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.HasOne("ExamAPP.Models.Department", "Departments")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("DepartmentsId");

                    b.HasOne("ExamAPP.Models.Instructor", "instructor")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("instructorId");

                    b.Navigation("Departments");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("CourseId");

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("StudentID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.HasOne("ExamAPP.Models.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });

            modelBuilder.Entity("ExamAPP.Models.Topic", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "courses")
                        .WithMany()
                        .HasForeignKey("coursesId");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Course", b =>
                {
                    b.Navigation("Ins_Course");

                    b.Navigation("Stud_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Department", b =>
                {
                    b.Navigation("Ins_Departments");

                    b.Navigation("dept_Crs");

                    b.Navigation("students");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.Navigation("dept_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Instructor", b =>
                {
                    b.Navigation("Ins_Course");

                    b.Navigation("Ins_Departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.Navigation("Stud_Crs");
                });
#pragma warning restore 612, 618
        }
    }
}
