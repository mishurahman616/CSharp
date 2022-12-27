using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem.Entities;
using StudentAttendanceSystem.Services;
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

        public static Student Login((string username, string password, UserTypes usertype) loginInfo)
        {
            SASDbContext sasDbContext = new SASDbContext();
            Student student = sasDbContext.Students.Where((x) => x.Username == loginInfo.username).FirstOrDefault();

            if (student?.Password == loginInfo.password)
            {
                Console.WriteLine($"Welcome {student.Name}");
            }
            else
            {
                Console.WriteLine("Username and Passwrod Mismatched!");
            }
            return student;
        }

        public void ShowTaskList()
        {
            Console.WriteLine(@"Students Area:
        1. Give Attendance      
        ");
            GiveAttenDance();
        }

        public void GiveAttenDance()
        {
            Console.WriteLine("Select Course: ");
            SASDbContext sasDbContext = new SASDbContext();
            Student student = sasDbContext.Students.Where(x => x.Id == Id)
               .Include(x => x.StudentCourses)
                .ThenInclude(x => x.Course)
                .ThenInclude(x=>x.Schedules)
                .FirstOrDefault();
            
            int courseIndex = 1;
            if(student != null)
            {
                foreach (CourseRegistration cour in student.StudentCourses)
                {
                    Console.WriteLine($"{courseIndex++}. {cour.Course.Name}");
                }
                int chooseCourseOption = Convert.ToInt32(Console.ReadLine());
                bool isAttendanceTime = ValidateAttendanceDateTime(student.StudentCourses[chooseCourseOption - 1].Course);
                if (isAttendanceTime)
                {
                    Attendance attendance = new Attendance();
                    attendance.Student = student;
                    attendance.StudentId = student.Id;
                    attendance.Course = student.StudentCourses[chooseCourseOption - 1].Course;
                    attendance.CourseId = student.StudentCourses[chooseCourseOption - 1].Course.Id;
                    attendance.IsPresent = true;
                    attendance.AttendanceDate = DateTime.Now.Date;
                    sasDbContext.Add(attendance);
                    sasDbContext.SaveChanges();
                    Console.WriteLine("Attendance Given Successfully");
                }
                else
                {
                    Console.WriteLine($"{DateTime.Now.ToString("f")} is not your class Time!");
                }
            }

        }

        private bool ValidateAttendanceDateTime(Course course)
        {
            int classCount = 0;
            foreach(var schedule in course.Schedules)
            {
                if(schedule.ClassDay==DateTime.Today.DayOfWeek.ToString() && DateTime.Today.Date>= schedule.ClassStartDate.Date)
                {
                    classCount++;
                    if (classCount > schedule.TotalClass)
                    {
                        return false;
                    }
                    if(schedule.ClassStartTime.Hour<=DateTime.Now.Hour && schedule.ClassEndTime.Hour>=DateTime.Now.Hour)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
