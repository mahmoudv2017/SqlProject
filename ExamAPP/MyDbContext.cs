using ExamAPP.Models;
using ExamAPP.Models.Mahmoud;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=.; database=ExamDB; Trusted_connection=true;encrypt=false;");
        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Dept_Crs> dept_Crs { get; set; }
        public DbSet<Ins_Course> ins_Courses { get; set; }
        public DbSet<Ins_Department> ins_Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Crs> stud_Crs { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public DbSet<Choices> Choices { get; set; }
        public DbSet<Exam_Question> Exam_Question { get; set; }

        public DbSet<Student_Exams> Student_Exams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mahmoud's Region

                #region Exam Relation
                    modelBuilder.Entity<Exam>().HasKey(e => e.Ex_Id);
                    modelBuilder.Entity<Exam>()
                        .HasOne(e => e.Course)
                        .WithMany(e => e.Crs_Exams)
                        .HasForeignKey(e => e.CrsID);
                #endregion

                #region questions & choices
                modelBuilder.Entity<Choices>().HasKey(e => e.Ch_Id);

                modelBuilder.Entity<Choices>().HasOne(e => e.Question)
                    .WithMany(e => e.Choices)
                    .HasForeignKey(e => e.Q_ID);

                modelBuilder.Entity<Question>().HasKey(e => e.Q_Id);

            #endregion

            #region Many to many relations
                modelBuilder.Entity<Student_Exams>().HasKey(e => new { e.St_ID, e.Ex_ID });
                modelBuilder.Entity<Student_Exams>()
                   .HasOne(e => e.Student)
                   .WithMany(e => e.Student_Exams)
                   .HasForeignKey(e => e.St_ID);


                modelBuilder.Entity<Student_Exams>()
                   .HasOne(e => e.Exam)
                   .WithMany(e => e.Student_Exams)
                   .HasForeignKey(e => e.Ex_ID);
            modelBuilder.Entity<Exam_Question>().HasKey(e => new { e.Ex_ID, e.Ques_ID });

            modelBuilder.Entity<Exam_Question>()
                .HasOne(e => e.Ex_Questions)
                .WithMany(e => e.Exam_Question)
                .HasForeignKey(e => e.Ques_ID);


                modelBuilder.Entity<Exam_Question>()
                   .HasOne(e => e.Exam)
                   .WithMany(e => e.Exam_Question)
                   .HasForeignKey(e => e.Ex_ID);


            #endregion

            #endregion


            #region Mina & Mona
                modelBuilder.Entity<Student>(config =>
                {
                    config.HasOne(s => s.department)
                    .WithMany(q => q.students)
                    .HasForeignKey(s => s.DeptId);

                });
            #endregion
            base.OnModelCreating(modelBuilder); 
        }
    }
}
