using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models
{
    public class SupplierOrder
    {
        public int SupplierOrderID { get; set; }


        public int addedQty { get; set; }

        public String ItemName { get; set; }

        public String description { get; set; }

        public double unitPrice { get; set; }

        public double itemTotalPrice { get; set; }

        public DateTime addedTime { get; set; }

        public DateTime addedDate { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
