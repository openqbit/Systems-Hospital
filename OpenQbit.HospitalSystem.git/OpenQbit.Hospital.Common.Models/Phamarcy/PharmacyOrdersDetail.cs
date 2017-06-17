
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{

    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class PharmacyOrdersDetail
        {
            public int ID { get; set; }

            public int OrderQty { get; set; }

            public String ItemName { get; set; }

            public double UnitPrice { get; set; }

            public double ItemTotalPrice { get; set; }

            public virtual Category Category { get; set; }
        }
    }
}