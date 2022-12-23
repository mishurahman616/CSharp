using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    [Index(nameof(Username), IsUnique = true)]
    public class Teacher:User
    {
        public List<Course> Courses { get; set; }



        public Teacher(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
            UserType = "Teacher";
        }
    }

}
