using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Ins_Department
    {
    
        public int Ins_ID { get; set; }
        public int Dept_ID { get; set; }
        public Instructor? Instructor { get; set; }  
        public Department? Departments { get; set; }
    }
}
