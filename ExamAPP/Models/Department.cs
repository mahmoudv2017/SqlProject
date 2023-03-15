using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptNames { get; set; } = string.Empty;
        public ICollection<Dept_Crs>? dept_Crs { get; set; }
        public ICollection<Ins_Department>? Ins_Departments { get; set; }
        public ICollection<Student>? students { get; set; }
    }
}
