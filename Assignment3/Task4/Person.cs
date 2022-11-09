using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
         public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public virtual void GenerateId()
        {
           
        }
    }
}
