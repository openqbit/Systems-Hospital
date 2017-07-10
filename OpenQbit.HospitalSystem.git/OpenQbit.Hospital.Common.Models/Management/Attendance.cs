using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Management
{
   public  class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SystemId { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime ShortLeaveInTime { get; set; }
        public DateTime ShortLeaveOutTime { get; set; }
        public DateTime OTHourse { get; set; }


        public virtual Employee Employee { get; set; }
    }
}
