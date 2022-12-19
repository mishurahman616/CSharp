using StudentAttendaceManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentAttendaceManagementSystem.Entities
{
    internal class Course : ICourse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Fees { get ; set ; }
        public DateTime ClassDay { get; set; }
        public DateTime ClassStartTime { get; set; }
        public DateTime ClassEndTime { get; set; }
        public int TotalClass { get; set; }

    }
}
