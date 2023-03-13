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
    [Migration("20230313215011_v7")]
    partial class v7
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

                    b.Property<int>("Ins_Courseid")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Ins_Courseid");

                    b.HasIndex("departmentId");

                    b.ToTable("dept_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("instructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("courseId");

                    b.HasIndex("instructorId");

                    b.ToTable("ins_Courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.Property<int>("instructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

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

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Choices", b =>
                {
                    b.Property<int>("Ch_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ch_Id"));

                    b.Property<string>("Ch_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Q_ID")
                        .HasColumnType("int");

                    b.HasKey("Ch_Id");

                    b.HasIndex("Q_ID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.Property<int>("Ex_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ex_Id"));

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("Ex_Marks")
                        .HasColumnType("int");

                    b.Property<string>("Ex_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ex_Id");

                    b.HasIndex("CrsID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam_Question", b =>
                {
                    b.Property<int>("Ex_ID")
                        .HasColumnType("int");

                    b.Property<int>("Ques_ID")
                        .HasColumnType("int");

                    b.HasKey("Ex_ID", "Ques_ID");

                    b.HasIndex("Ques_ID");

                    b.ToTable("Exam_Question");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Question", b =>
                {
                    b.Property<int>("Q_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Q_Id"));

                    b.Property<int>("AnsID")
                        .HasColumnType("int");

                    b.Property<string>("AnsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Q_Mark")
                        .HasColumnType("int");

                    b.Property<string>("QuesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Q_Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Student_Exams", b =>
                {
                    b.Property<int>("St_ID")
                        .HasColumnType("int");

                    b.Property<int>("Ex_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("St_ID", "Ex_ID");

                    b.HasIndex("Ex_ID");

                    b.ToTable("Student_Exams");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("courseId");

                    b.HasIndex("studentId");

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

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("courseId");

                    b.ToTable("topics");
                });

            modelBuilder.Entity("ExamAPP.Models.Dept_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Ins_Course", "Ins_Course")
                        .WithMany("dept_Crs")
                        .HasForeignKey("Ins_Courseid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Department", "department")
                        .WithMany("dept_Crs")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ins_Course");

                    b.Navigation("department");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "courses")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Instructor", "Instructors")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructors");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.HasOne("ExamAPP.Models.Department", "Departments")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Instructor", "instructor")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Choices", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("Q_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Crs_Exams")
                        .HasForeignKey("CrsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam_Question", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Exam", "Exam")
                        .WithMany("Exam_Question")
                        .HasForeignKey("Ex_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Mahmoud.Question", "Ex_Questions")
                        .WithMany("Exam_Question")
                        .HasForeignKey("Ques_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ex_Questions");

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Student_Exams", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Exam", "Exam")
                        .WithMany("Student_Exams")
                        .HasForeignKey("Ex_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Student_Exams")
                        .HasForeignKey("St_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .WithMany("Topics")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Course", b =>
                {
                    b.Navigation("Crs_Exams");

                    b.Navigation("Ins_Courses");

                    b.Navigation("Stud_Crs");

                    b.Navigation("Topics");
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
                    b.Navigation("Ins_Courses");

                    b.Navigation("Ins_Departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.Navigation("Exam_Question");

                    b.Navigation("Student_Exams");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Question", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("Exam_Question");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.Navigation("Stud_Crs");

                    b.Navigation("Student_Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
