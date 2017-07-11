using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiDoctor
    {
        public int DoctorID { get; set; }

        public int EmployeeId { get; set; }
        public virtual ApiEmployee ApiEmployee { get; set; }
    }
}