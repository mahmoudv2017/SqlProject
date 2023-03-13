using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamAPP.Models.Mahmoud;

namespace ExamAPP.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<Topic> ?Topics { get; set; }
        public  ICollection<Ins_Course>? Ins_Courses { get; set; }
        public ICollection<Stud_Crs>? Stud_Crs { get; set; }
        public ICollection<Exam>? Crs_Exams { get; set; }
    }
}
