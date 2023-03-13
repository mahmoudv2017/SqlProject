using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public ICollection<Ins_Course> ?Ins_Courses { get; set; }
        public ICollection<Ins_Department> ?Ins_Departments { get; set; }
    }
}
