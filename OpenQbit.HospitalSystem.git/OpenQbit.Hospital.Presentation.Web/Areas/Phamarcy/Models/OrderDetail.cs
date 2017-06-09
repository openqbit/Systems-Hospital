using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int orderQty { get; set; }

        public String ItemName { get; set; }

        public double unitPrice { get; set; }

        public double itemTotalPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}