using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    internal class Student:User
    {
        public Student()
        {
            UserType = "Student";
        }
        public Student(string name, string username, string password) : this()
        {
            Name = name;
            Username = username;
            Password = password;
        }
        public Student(User user):this()
        {
            Id = user.Id;
            Name = user.Name;
            Username = user.Username;
            Password = user.Password;
        }
    }
}
