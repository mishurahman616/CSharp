﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using StudentAttendanceSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Entities
{
    [Index(nameof(Username), IsUnique = true)]
    public class Admin : User
    {
        public Admin(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
            UserType = "Admin";
        }

        public static object Login((string username, string password, UserTypes userTypes) loginInfo)
        {
            SASDbContext sasDbContext = new SASDbContext();

            Admin admin = sasDbContext.Admins.Where((x) => x.Username == loginInfo.username).FirstOrDefault();

            if (admin?.Password == loginInfo.password)
            {
                Console.WriteLine($"Welcome {admin.Name}");
            }
            else
            {
                Console.WriteLine("Username and Passwrod Mismatched!");
            }
            return admin;
        }


        public void ShowAdminTaskList()
        {
            Console.WriteLine(@"Admin Area-
        1. Create Teacher
        2. Create Student
        3. Create Course
        4. Assign a Teacher to a Course
        5. Assign a Student to a Course
        6. Set Class Schedule to a Course
        
        ");
            int taskOption = Convert.ToInt32(Console.ReadLine());
            DoTask(taskOption);
        }


        public void DoTask(int taskOption)
        {
            if (taskOption == 1)
            {
                CreateUser(UserTypes.Teacher);
            }
            else if (taskOption == 2)
            {
                CreateUser(UserTypes.Student);
            }
            else if (taskOption == 3)
            {
                CreateCourse();
            }
            else if (taskOption == 4)
            {
                AssignTeacherToCourse();
            }
            else if (taskOption == 5)
            {
                AssignStudentToCourse();
            }
            else if (taskOption == 6)
            {
                SetClassSchedule();
            }
            else
            {
                Console.WriteLine("Please select Correct option");
            }
        }


        public string CreateUser(UserTypes type)
        {
            SASDbContext samsDbContext = new SASDbContext();
            string usertype = type.ToString();
            Console.WriteLine("Enter Name of the " + usertype);
            string name = Console.ReadLine();
            Console.WriteLine("Enter username of the " + usertype);
            string username = Console.ReadLine();
            Console.WriteLine("Enter password for the " + usertype);
            string password = Console.ReadLine();

            if (type == UserTypes.Teacher)
            {

                Teacher teacher = new Teacher(
                Name = name,
                Username = username,
                Password = password);
                samsDbContext.Add(teacher);
                samsDbContext.SaveChanges();
                Console.WriteLine($"{UserTypes.Teacher} Profile name: {name} Created Successfully");
            }
            else if (type == UserTypes.Student)
            {
                Student student = new Student(
                Name = name,
                Username = username,
                Password = password);
                samsDbContext.Add(student);
                samsDbContext.SaveChanges();
                Console.WriteLine($"{UserTypes.Student} Profile name: {name} Created Successfully");
            }
            return username;
        }


        public void CreateCourse()
        {
            SASDbContext samsDbContext = new SASDbContext();
            Course course = new Course();

        EnterValidName:
            Console.WriteLine("Enter Course Title: ");
            string name = Console.ReadLine();
            if (name.Trim() == null) goto EnterValidName;
            Console.WriteLine("Enter Course Fees: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Class Start Date(dd-MM--yyyy): ");
            //enterValidDate:
            //DateTime classStartDate;
            //if(!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out classStartDate))
            //{
            //    Console.WriteLine("Please Enter Valid Date.");
            //    goto enterValidDate;
            //}
            //Console.WriteLine("Enter Total number of Class");
            //int totalClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@"1. Assign existing teacher to course
2. Assign new Teacher to course");


            int teacherOption = Convert.ToInt32(Console.ReadLine());
            string tUsername = " ";
            if (teacherOption == 1)
            {
                Console.WriteLine("Enter Teacher's username: ");
                tUsername = Console.ReadLine();


            }
            else if (teacherOption == 2)
            {
                tUsername = CreateUser(UserTypes.Teacher);
            }
            Teacher teacher = samsDbContext.Teachers.Where(x => x.Username == tUsername.Trim()).FirstOrDefault();
            if (teacher != null)
            {
                course.Teacher = teacher;
            }
            else
            {
                Console.WriteLine("Teacher Assign Failed!");
                return;
            }

            course.Name = name;
            course.Fees = fees;
            //course.ClassStartDate= classStartDate;
            //course.TotalClass = totalClass;
            samsDbContext.Add(course);
            samsDbContext.SaveChanges();
        }




        public void AssignTeacherToCourse()
        {
            SASDbContext samsDbContext = new SASDbContext();
            Course course;

            Console.WriteLine("Enter Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            course = samsDbContext.Courses.Where(x => x.Id == courseId).FirstOrDefault();
            if (course != null)
            {
                Console.WriteLine(@"1. Assign existing teacher to course
2. Assign new Teacher to course");


                int teacherOption = Convert.ToInt32(Console.ReadLine());
                string tUsername = " ";
                if (teacherOption == 1)
                {
                    Console.WriteLine("Enter Teacher's username: ");
                    tUsername = Console.ReadLine();


                }
                else if (teacherOption == 2)
                {
                    tUsername = CreateUser(UserTypes.Teacher);
                }
                Teacher teacher = samsDbContext.Teachers.Where(x => x.Username == tUsername.Trim()).FirstOrDefault();
                if (teacher != null)
                {
                    course.Teacher = teacher;
                }
                else
                {
                    Console.WriteLine("Teacher Assign Failed!");
                    return;
                }


                samsDbContext.SaveChanges();
            }

        }



        public void AssignStudentToCourse()
        {
            SASDbContext samsDbContext = new SASDbContext();
            Course course;

            Console.WriteLine("Enter Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            course = samsDbContext.Courses.Where(x => x.Id == courseId).FirstOrDefault();
            if (course != null)
            {
                Console.WriteLine(@"1. Assign existing Student the to course
2. Assign new Student to the course");


                int studentOption = Convert.ToInt32(Console.ReadLine());
                string tUsername = " ";
                if (studentOption == 1)
                {
                    Console.WriteLine("Enter Student's username: ");
                    tUsername = Console.ReadLine();


                }
                else if (studentOption == 2)
                {
                    tUsername = CreateUser(UserTypes.Student);
                }
                Student student = samsDbContext.Students.Where(x => x.Username == tUsername.Trim()).FirstOrDefault();
                if (student != null)
                {
                    course.CourseStudents = new List<CourseRegistration>();
                    course.CourseStudents.Add(new CourseRegistration { Student = student });
                }
                else
                {
                    Console.WriteLine("Student Assign Failed!");
                    return;
                }

                samsDbContext.SaveChanges();
            }

        }



        public void SetClassSchedule()
        {
            SASDbContext samsDbContext = new SASDbContext();
            Course course;
            Console.WriteLine("Enter CourseId");
            int courseId = Convert.ToInt32(Console.ReadLine());
            course = samsDbContext.Courses.Where(x => x.Id == courseId).FirstOrDefault();
            if (course != null)
            {
                course.Schedules = new List<Schedule>();
                Console.WriteLine("Enter Class Start Date(dd-MM--yyyy): ");
            enterValidDate:
                DateTime classStartDate;
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out classStartDate))
                {
                    Console.WriteLine("Please Enter Valid Date.");
                    goto enterValidDate;
                }
                Console.Write("Enter total number of class: ");
                int totalClass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many Days class will be held in a week: ");
                List<(string classDay, string TimeStart, string TimeEnd)> courseDays = new List<(string, string, string)>();
                int courseDaysCount = Convert.ToInt32(Console.ReadLine());
                if (courseDaysCount > 0 || courseDaysCount <= 7)
                {
                    for (int i = 0; i < courseDaysCount; i++)
                    {
                        Console.WriteLine($"Enter Name of Day{i + 1}: ");
                        string classDay = Console.ReadLine();
                        Console.WriteLine("Enter Class Start Time on" + classDay + ": like (7AM) ");
                        string classStart = Console.ReadLine();
                        Console.WriteLine("Enter Class End Time on" + classDay + ": like (8AM)");
                        string classEnd = Console.ReadLine();
                        courseDays.Add((classDay, classStart, classEnd));
                    }
                }

                foreach(var courseDay in courseDays)
                {
                    course.Schedules.Add(new Schedule { ClassStartDate = classStartDate, ClassDay = courseDay.classDay, ClassStartTime = Convert.ToDateTime(courseDay.TimeStart), ClassEndTime = Convert.ToDateTime(courseDay.TimeEnd), TotalClass = totalClass });
                }

                samsDbContext.SaveChanges();
                Console.WriteLine("Course Schedule Added Succesfully");
            }

        }
    }
}
