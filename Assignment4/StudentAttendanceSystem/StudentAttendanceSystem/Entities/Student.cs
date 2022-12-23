using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    [Index(nameof(Username), IsUnique = true)]
    public class Student:User
    {
        public List<CourseRegistration> StudentCourses { get; set; }
        public List<Attendance> Attendances { get; set; }

        public Student(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
            UserType = "Student";
        }
    }
}
