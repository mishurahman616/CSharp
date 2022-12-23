using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fees { get; set; }
        public DateTime ClassStartDate { get; set; }
        public int TotalClass { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Course()
        {

        }
        public Course(string name, string fees, DateTime classStartDate, int totalClass)
        {
            Name = name;
            Fees = fees;
            ClassStartDate = classStartDate;
            TotalClass = totalClass;
        }
    }
}
