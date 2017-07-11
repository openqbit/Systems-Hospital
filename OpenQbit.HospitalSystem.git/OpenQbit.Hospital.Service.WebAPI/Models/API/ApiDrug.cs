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
        public class ApiDrug
        {
            public int ID { get; set; }

            public String drugName { get; set; }

            public String Description { get; set; }

            public String Company { get; set; }

            public int MedicineId { get; set; }

            public int CategoryId { get; set; }

            public virtual ApiMedicine Medicine { get; set; }
            public virtual ApiCategory Category { get; set; }

        }

    }
}