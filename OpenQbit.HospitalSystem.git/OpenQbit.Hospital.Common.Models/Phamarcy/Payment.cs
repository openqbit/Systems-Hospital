using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    public class Payment
    {
        public int ID { get; set; }

        public double totalAmount { get; set; }

        public double ItemDiscount { get; set; }

        public DateTime date { get; set; }

        public virtual PharmacyOrders PharmacyOrders { get; set; }
    }
}