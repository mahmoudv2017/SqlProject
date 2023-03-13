using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Dept_Crs
    {
        public int ID { get; set; }
        public int courseId { get; set; }
        public int departmentId { get; set; }
        public int Ins_Courseid {get; set; }
      public Department? department { get; set; }
        public Ins_Course? Ins_Course { get; set; }
    }
}
