﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime ClassStartDate { get; set; }
        public int TotalClass { get; set; }
        public string ClassDay { get; set; }
        public DateTime ClassStartTime { get; set; }
        public DateTime ClassEndTime { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
