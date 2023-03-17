using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models.Mahmoud
{
    public class Exam
    {
        public int Ex_Id { get; set; }
        public string Ex_Name { get; set; } = string.Empty;
        public int Ex_Marks { get; set; }
        public int CrsID { get; set; }

        public Course Course { get; set; }= new Course();

        public ICollection<Stude_Answers>? Stude_Answers { get; set; }
        public ICollection<Student_Exams>? Student_Exams { get; set; }
        public ICollection<Exam_Question_Crs> Exam_Question_Crs { get; set; } = new List<Exam_Question_Crs>();

    }
}
