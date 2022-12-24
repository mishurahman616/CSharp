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
            ViewStudentsAttendance();
        }

        public void ViewStudentsAttendance()
        {
            Console.WriteLine("Enter Students Id");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            SASDbContext sasDbContext = new SASDbContext();
            Student student = sasDbContext.Students.Where((x)=>x.Id == studentId).FirstOrDefault();
      //      Schedule schedule = sasDbContext.Courses.Where(x => x.Id == courseId).FirstOrDefault().Schedules[0];
            List<Schedule> schedules = sasDbContext.Courses.Where((x) => x.Id == courseId)
                .Include((x)=>x.Schedules)
                .FirstOrDefault().Schedules;
            List<string> classdays = new List<string>();
            Schedule schedule = schedules.FirstOrDefault();
            if (student != null && schedule != null) {
                foreach (var sce in schedules)
                {
                    classdays.Add(sce.ClassDay);
                }
                List<Attendance> attendances = sasDbContext.Attendances.Where(x => x.StudentId == studentId && x.CourseId == courseId).ToList();
                List<DateTime> presentDates = new List<DateTime>();
                foreach(var present in attendances)
                {
                    presentDates.Add(present.AttendanceDate.Date);
                }
                DateTime previousClassDate = schedule.ClassStartDate.Date;
                while (previousClassDate <= DateTime.Now.Date)
                {
                    if (attendances.Count > 0)
                    {
                        if (presentDates.Contains(previousClassDate.Date))
                        {
                            Console.WriteLine($"{student.Name} {previousClassDate.ToString("dd-MM-yyyy")} {"\u221A"}");
                        }
                        else
                        {
                            if (classdays.Contains(previousClassDate.DayOfWeek.ToString()))
                                Console.WriteLine($"{student.Name} {previousClassDate.ToString("dd-MM-yyyy")} x");
                        }
                    }
                    else
                    {
                        if (classdays.Contains(previousClassDate.DayOfWeek.ToString()))
                            Console.WriteLine($"{student.Name} {previousClassDate.ToString("dd-MM-yyyy")} x");
                    }
                    previousClassDate = previousClassDate.AddDays(1);
                }
            }
            else
            {
                Console.WriteLine("Course or Student not found");
            }
            

        }
    }

}
