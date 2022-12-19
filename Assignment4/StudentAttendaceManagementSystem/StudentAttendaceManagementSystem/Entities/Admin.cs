using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendaceManagementSystem.Entities
{
    internal class Admin:User
    {
        public Admin() { }
        public Admin(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }
    }
}
