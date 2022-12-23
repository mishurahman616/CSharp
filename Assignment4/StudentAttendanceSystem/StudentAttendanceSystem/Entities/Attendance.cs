using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId), nameof(AttendanceDateTime))]
    public class Attendance
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set;}
        public DateTime AttendanceDateTime { get; set; }
        public bool IsPresent { get; set; }

    }
}
