using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiTreatment
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int WardAdmitionID { get; set; }
        public virtual ApiWardAdmition WardAdmition { get; set; }
        public int DoctorID { get; set; }
        public virtual ApiDoctor Doctor { get; set; }
    }
}