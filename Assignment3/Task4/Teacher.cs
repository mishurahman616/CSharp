using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Teacher:Person
    {
       public string Id { get; private set; }

        public Teacher(string firstName, string lastName, string email):base(firstName, lastName, email)
        {
        }

        public override void GenerateId()
        {
            Id = "TE-" + DateTime.Now.Ticks.ToString();
        }
    }
}
