using OpenQbit.Hospital.Common.Models.Phamarcy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{

    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class Drug
        {
            public int DrugID { get; set; }

            public String DrugName { get; set; }

            public String Description { get; set; }

            public String Company { get; set; }

            public int MedicineId { get; set; }

            public int CategoryId { get; set; }

            public virtual Medicine Medicine { get; set; }
            public virtual Category Category { get; set; }

        }

    }
}