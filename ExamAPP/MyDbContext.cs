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
        public DbSet<Exam_Question_Crs> Exam_Question_Crs { get; set; }

        public DbSet<Student_Exams> Student_Exams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(x => x.Id);
            modelBuilder.Entity<Course>().HasData(new Course { Id=1, Title = "course_1" });
            #region Mahmoud's Region

                #region Exam Relation
                    modelBuilder.Entity<Exam>().HasKey(e => e.Ex_Id);
                

                    modelBuilder.Entity<Exam>()
                                .HasOne(e => e.Course)
                                .WithMany(e => e.Crs_Exams)
                                .HasForeignKey(e => e.CrsID);

                    modelBuilder.Entity<Exam>().HasData(new Exam { CrsID = 1, Ex_Marks = 50, Ex_Name = "asd", Ex_Id = 1 , Course= null });
            #endregion

                #region questions & choices

                modelBuilder.Entity<Choices>().HasKey(e => e.Ch_Id);

                    modelBuilder.Entity<Choices>().HasOne(e => e.Question)
                        .WithMany(e => e.Choices)
                        .HasForeignKey(e => e.Q_ID);


                    modelBuilder.Entity<Question>().HasKey(e => e.Q_Id);
                    modelBuilder.Entity<Question>().HasData(new Question { Q_Id=1, Q_Mark = 25, AnsID = 1, AnsTitle = "asdjnasd", QuesTitle = "asdasd", type = "MCQ" , CrsID=1 });
                modelBuilder.Entity<Question>(config =>
                {
                    config.HasOne(q => q.Course)
                    .WithMany(c => c.Question)
                    .HasForeignKey(q => q.CrsID);
                });

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

                modelBuilder.Entity<Exam_Question_Crs>().HasData(new Exam_Question_Crs { Crs_ID = 1, Ex_ID = 1, Ques_ID = 1 , Course=null , Exam= null , Ex_Questions=null });
                modelBuilder.Entity<Exam_Question_Crs>().HasKey(e => new { e.Ex_ID, e.Ques_ID , e.Crs_ID });
           

                modelBuilder.Entity<Exam_Question_Crs>()
                    .HasOne(e => e.Ex_Questions)
                    .WithMany(e => e.Exam_Question_Crs)
                    .HasForeignKey(e => e.Ques_ID)
                    .OnDelete(DeleteBehavior.NoAction);
        


                    modelBuilder.Entity<Exam_Question_Crs>()
                       .HasOne(e => e.Exam)
                       .WithMany(e => e.Exam_Question_Crs)
                       .HasForeignKey(e => e.Ex_ID)
                        .OnDelete(DeleteBehavior.NoAction);


                modelBuilder.Entity<Exam_Question_Crs>()
                    .HasOne(e => e.Course)
                    .WithMany(e => e.Exam_Question_Crs)
                    .HasForeignKey(e => e.Crs_ID)
                     .OnDelete(DeleteBehavior.NoAction);









            modelBuilder.Entity<Stude_Answers>().HasKey(e => new { e.Ex_id, e.Q_id, e.Stud_id });


            modelBuilder.Entity<Stude_Answers>()
                .HasOne(e => e.Student)
                .WithMany(e => e.Stude_Answers)
                .HasForeignKey(e => e.Stud_id)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Stude_Answers>()
               .HasOne(e => e.Exam)
               .WithMany(e => e.Stude_Answers)
               .HasForeignKey(e => e.Ex_id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Stude_Answers>()
               .HasOne(e => e.Question)
               .WithMany(e => e.Stude_Answers)
               .HasForeignKey(e => e.Q_id)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Stude_Answers>()
                .HasOne(e => e.Answer)
                .WithMany(e => e.Stude_Answers)
                .HasForeignKey(e => e.ch_id)
                 .OnDelete(DeleteBehavior.NoAction);


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
