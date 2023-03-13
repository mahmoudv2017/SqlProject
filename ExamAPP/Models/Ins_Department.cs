using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Ins_Department
    {
        public int Id { get; set; }
        public int instructorId { get; set; }
        public int departmentId { get; set; }
        public Instructor ?instructor { get; set; }  
        public Department ?Departments { get; set; }
    }
}
