using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{

    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class Payment
        {
            public int PaymentID { get; set; }

            public double TotalAmount { get; set; }

            public double ItemDiscount { get; set; }

            public DateTime Date { get; set; }

            public virtual PharmacyOrders PharmacyOrders { get; set; }
        }
    }
}