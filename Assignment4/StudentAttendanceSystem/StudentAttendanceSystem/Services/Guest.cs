using StudentAttendanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Services
{
    public class Guest
    {
        public static (string username, string password, UserTypes usertype) CollectLoginInfo()
        {
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine(@"Login as: 
1. Admin
2. Teacher
3. Student");
            UserTypes userType = (UserTypes)Convert.ToInt32(Console.ReadLine());
            return (username, password, userType);
        }

        
    }
}
