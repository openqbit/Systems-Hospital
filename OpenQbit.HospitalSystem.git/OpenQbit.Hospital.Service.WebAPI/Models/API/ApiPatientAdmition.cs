using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiPatientAdmition
    {
        public int ID { get; set; }

        public int PatientId { get; set; }
        public ApiPatient Patient { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<ApiPharmacyOrders> Orders { get; set; }
    }
}