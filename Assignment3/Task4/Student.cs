using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student:Person
    {
        public string Id { get; private set; }

        public Student(string firstName, string lastName, string email):base(firstName, lastName, email)
        {
        }

        public override void GenerateId()
        {
            Id = "ST-" + DateTime.Now.Ticks.ToString();
        }
    }
}
