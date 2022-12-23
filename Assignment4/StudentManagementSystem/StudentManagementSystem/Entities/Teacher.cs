using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Entities
{
    public class Teacher:User
    {
        public List<Course> Courses { get; set; }
    }
}
