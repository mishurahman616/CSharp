using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {

        private const string _userNameInvalidMessage = "Username must be provided";
        private const string _emailNameInvalidMessage = "Email must be provided";
        private const string _passwordNameInvalidMessage = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return _userNameInvalidMessage;
            if (string.IsNullOrWhiteSpace(email))
                return _emailNameInvalidMessage;
            if (string.IsNullOrWhiteSpace(password))
                return _passwordNameInvalidMessage;

            return string.Empty;
        }
    }
}
