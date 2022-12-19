using StudentAttendaceManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendaceManagementSystem.Entities
{
    internal class Course : ICourse
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Fees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ClassDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSpan ClassTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
