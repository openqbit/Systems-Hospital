using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiPharmacyOrders
    {
        public int ID { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; }

        public int PatientAdmitionId { get; set; }

        public virtual ApiPatientAdmition PatientAdmition { get; set; }

        public virtual ICollection<ApiPayment> Payment { get; set; }
    }
}