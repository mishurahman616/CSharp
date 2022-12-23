using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    internal class Teacher:User
    {

        Teacher()
        {
            UserType = "Teacher";
        }
        public Teacher(string name, string username, string password):this()
        {
            Name = name;
            Username = username;
            Password = password;
        }
        public Teacher(User user):this()
        {
            Id = user.Id;
            Name = user.Name;
            Username = user.Username;
            Password = user.Password;
        }
    }
}
