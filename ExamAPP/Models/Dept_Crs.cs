using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Dept_Crs
    {
        public int Course_Id { get; set; }
        public int Department_Id { get; set; }
      public Course? Course { get; set; }
      public Department? Department { get; set; }
    }
}
