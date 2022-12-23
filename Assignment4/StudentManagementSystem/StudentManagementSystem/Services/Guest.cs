using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static StudentManagementSystem.Services.Guest;

namespace StudentManagementSystem.Services
{
    public static class Guest
    {
        public static User Login()
        {

            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine(@"Login as: 
        1. Admin
        2. Teacher
        3. Student");
            int userType = Convert.ToInt32(Console.ReadLine());

            User user;
            bool isLoginSuccess;

            LoginCheck(username, password, userType, out user, out isLoginSuccess);
            if (isLoginSuccess)
            {
                Console.WriteLine($"Login As {((UserType)userType).ToString()} Successfull!");
                return user;
            }
            else
            {
                Console.WriteLine("Login Failed");
                return user;
            }
            
        }
        private static void LoginCheck(string username, string password, int userType, out User user, out bool loginCheck)
        {
            SMSDbContext smsDbContext = new SMSDbContext();
             user = smsDbContext.Users.Where(x => x.UserType == ((UserType)userType).ToString() && x.Username == username).FirstOrDefault();

            if (user?.Password == password)
            {
               loginCheck= true;
            }
            else
            {
               loginCheck= false;
            }
        }
        public enum UserType
        {
            Admin=1,
            Teacher,
            Student
        }

    }
}
