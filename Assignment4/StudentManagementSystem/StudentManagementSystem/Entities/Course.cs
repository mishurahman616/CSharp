using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Entities
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Fees { get; set; }
        public DateTime ClassDay { get; set; }
        public DateTime ClassStartTime { get; set; }
        public DateTime ClassEndTime { get; set; }
        public int TotalClass { get; set; }
    }
}
