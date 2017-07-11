using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiPatient
    {
        public int ID { get; set; }
        public String PatientName { get; set; }
        public virtual ICollection<ApiPatientAdmition> PatientAdmition { get; set; }
    }
}