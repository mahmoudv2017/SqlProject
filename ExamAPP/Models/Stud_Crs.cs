using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
  public class Stud_Crs
    {

        public int Course_Id { get; set; }
        public int Student_Id { get; set; }

        public int Grade { get; set; }

        public Course? Course { get; set;}
        public Student? Student  { get; set; }

    }
}
