using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId), nameof(AttendanceDate))]
    public class Attendance
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set;}
        [Column(TypeName = "Date")]
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }

    }
}
