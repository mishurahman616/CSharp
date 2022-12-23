using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public class Admin:User
    {
        public Admin()
        {
            UserType = "Admin";
        }
        public Admin(string name, string username, string password) : this()
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public Admin(User user):this()
        {
            Id=user.Id;
            Name = user.Name;
            Username = user.Username;
            Password = user.Password;
        }

        public void ShowAdminTaskList()
        {
            Console.WriteLine(@"Admin Area:
        1. Create Teacher
        2. Create Student
        3. Creagte Course
        4. Assign a Teacher to a Course
        5. Assign a Student to a Course
        6. Set Class Schedule to a Course
        0. To Go Home.
        9. Logout
        ");
            DoTask();
        }
        public void DoTask()
        {
            string taskId = Console.ReadLine();
            if (taskId == "0") ShowAdminTaskList();
            else if (taskId == "*") Guest.Login();
            else if (taskId == "1") CreateTeacher();
            else if (taskId == "2") CreateStudent();
            else if (taskId == "3") CreateCourse();
            ShowAdminTaskList();
        }
        private void GetUserInfo(out string name, out string username, out string password, string usertype)
        {
            Console.WriteLine("Enter {0} Name: ", usertype);
            name = Console.ReadLine();
            Console.WriteLine("Enter {0} Username: ", usertype);
            username = Console.ReadLine();
            Console.WriteLine("Enter password for {0}", usertype);
            password = Console.ReadLine();
        }
        public void CreateTeacher()
        {
            string name, username, password;
            string usertype = Guest.UserType.Teacher.ToString();
            GetUserInfo(out name, out username, out password, usertype );
            Teacher teacher = new Teacher(name, username, password);
            SMSDbContext smsct = new SMSDbContext();
            smsct.Add( teacher );
            smsct.SaveChanges();
            Console.WriteLine($"{usertype} name: {name} Created Successfully.");
        }
        public void CreateStudent()
        {
            string name, username, password;
            string usertype = Guest.UserType.Student.ToString();
            GetUserInfo(out name, out username, out password, usertype);
            Student student = new Student(name, username, password);
            SMSDbContext smsct = new SMSDbContext();
            smsct.Add(student);
            smsct.SaveChanges();
            Console.WriteLine($"{usertype} name: {name} Created Successfully.");
        }
        public void CreateCourse()
        {
            Console.WriteLine("Enter course Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter course Fees: ");
            string fee = Console.ReadLine();
            Console.WriteLine("Enter Class Start Day: ");
            DateTime classStartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter total number of Class: ");
            int totalClasses = Convert.ToInt32(Console.ReadLine());
            Course course = new Course(name, fee, classStartDate, totalClasses);
            SMSDbContext smsct = new SMSDbContext();
            smsct.Add(course);
            smsct.SaveChanges();

        }

     

    }
}
