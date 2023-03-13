using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Topic
    {
        public int ID { get; set; }
        public int courseId { get; set; }
        public string ?Title { get; set; }
        public Course ?courses { get; set; }
    }
}
