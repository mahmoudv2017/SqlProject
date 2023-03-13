using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
  public class Stud_Crs
    {
        public int Id { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }
        public Course ?Course { get; set;}
        public Student ?Student  { get; set; }

    }
}
