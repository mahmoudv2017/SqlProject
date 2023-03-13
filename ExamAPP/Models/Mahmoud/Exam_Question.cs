using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models.Mahmoud
{
    public class Exam_Question
    {
        public int Ex_ID { get; set; }
        public int Ques_ID { get; set; }
        public Question? Ex_Questions { get; set;}
        public Exam? Exam { get; set; }
    }
}
