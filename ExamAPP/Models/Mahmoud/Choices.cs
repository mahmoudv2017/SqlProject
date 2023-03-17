using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models.Mahmoud
{
    public class Choices
    {
        public int Ch_Id { get; set; }

        public string Ch_Title { get; set;} = string.Empty;

        public int Q_ID { get; set; }

        public Question? Question { get; set; }
        public ICollection<Stude_Answers>? Stude_Answers { get; set; }

    }
}
