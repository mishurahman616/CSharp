using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
