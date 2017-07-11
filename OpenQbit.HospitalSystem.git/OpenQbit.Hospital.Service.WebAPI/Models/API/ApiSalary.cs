using OpenQbit.Hospital.Service.WebAPI.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Management
{
    public class ApiSalary
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double Transport { get; set; }
        public double OT { get; set; }
        public double Tax { get; set; }
        public double EPF { get; set; }
        public double EF { get; set; }
        public double NoPay { get; set; }

        public virtual ApiEmployee Employee { get; set; }
    }
}
