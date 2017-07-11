using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiPayment
    {
        public int ID { get; set; }

        public double TotalAmount { get; set; }

        public double ItemDiscount { get; set; }

        public DateTime Date { get; set; }

        public virtual ApiPharmacyOrders PharmacyOrders { get; set; }
    }
}