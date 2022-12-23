using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static Teacher Login((string username, string password, UserTypes usertype) loginInfo)
        {
            SASDbContext sasDbContext = new SASDbContext();
            Teacher teacher = sasDbContext.Teachers.Where((x) => x.Username == loginInfo.username).FirstOrDefault();

            if (teacher?.Password == loginInfo.password)
            {
                Console.WriteLine($"Welcome {teacher.Name}");
            }
            else
            {
                Console.WriteLine("Username and Passwrod Mismatched!");
            }
            return teacher;
        }

        public void ShowTaskList()
        {
            Console.WriteLine(@"Teachers Area:
          View Students Attendance     
        ");
          
        }

        public void ViewStudentsAttendance()
        {
            Console.WriteLine("Enter Students Id");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            SASDbContext sasDbContext = new SASDbContext();
            Schedule schedule = sasDbContext.Courses.Where(x => x.Id == courseId).FirstOrDefault().Schedules[0];
            List<Attendance> attendancePresent = sasDbContext.Attendances.Where(x => x.StudentId == studentId && x.CourseId == courseId).ToList();
            DateTime courseEndTime = DateTime.Now.Date;
            while (schedule.ClassStartDate <= DateTime.Now)
            {

            }

        }
    }

}
