using ExamAPP.Models.Mahmoud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public Department? department { get; set; }
        public ICollection<Stud_Crs>? Stud_Crs { get; set; }
        public ICollection<Student_Exams>? Student_Exams { get; set; }
        public ICollection<Stude_Answers>? Stude_Answers { get; set; }
    }
}
