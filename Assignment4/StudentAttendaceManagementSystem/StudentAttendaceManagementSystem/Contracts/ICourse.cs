using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendaceManagementSystem.Contracts
{
     public interface ICourse
    {
        string Id { get; set; }
        string Name { get; set; }
        string Fees { get; set; }
        public DateTime ClassDay { get; set; }
        public DateTime ClassStartTime { get; set; }
        public DateTime ClassEndTime { get; set; }

    }
}
