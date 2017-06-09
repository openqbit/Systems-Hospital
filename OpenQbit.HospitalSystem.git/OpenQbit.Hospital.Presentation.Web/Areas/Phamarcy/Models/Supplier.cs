using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        public String supplierName { get; set; }

        public String supplierContactNo { get; set; }

        public String supplierEmail { get; set; }

        public String brand{ get; set; }

        public String address { get; set; }


        public virtual ICollection<SupplierOrder> SupplierOrder { get; set; }
    }
}