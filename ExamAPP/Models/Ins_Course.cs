﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models
{
    public class Ins_Course
    {
        public int Id { get; set; }
        public int courseId { get; set; }
        public int instructorId { get; set; }

        public Course? courses { get; set; }
        public Instructor ? Instructors { get; set; }
        public ICollection<Dept_Crs>? dept_Crs { get; set; }

    }
}
