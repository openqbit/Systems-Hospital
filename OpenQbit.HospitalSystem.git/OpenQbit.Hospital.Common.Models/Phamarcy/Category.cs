using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class Category
        {
            public int CategoryID { get; set; }

            public String CategoryName { get; set; }

            // public virtual ICollection<PharmacyOrdersDetail> OrderDetail { get; set; }

            public virtual ICollection<Drug> Drug { get; set; }
        }
    }
}