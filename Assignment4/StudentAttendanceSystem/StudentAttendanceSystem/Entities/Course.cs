using StudentAttendanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set;}
        public List<Schedule> Schedules{ get; set; }
        public List<CourseRegistration> CourseStudents { get; set; }
        public List<Attendance> Attendances { get; set; }

        public Course(string name, double fees)
        {
            Name = name;
            Fees = fees;
        }
    }
}
