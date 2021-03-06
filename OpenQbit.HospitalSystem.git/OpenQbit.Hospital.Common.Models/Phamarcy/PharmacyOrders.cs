﻿
using OpenQbit.Hospital.Common.Models.OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{

    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class PharmacyOrders
        {
            public int ID { get; set; }

            public DateTime Time { get; set; }

            public DateTime Date { get; set; }

            public int PatientAdmitionId { get; set; }

            public virtual PatientAdmition PatientAdmition { get; set; }

            public virtual ICollection<Payment> Payment { get; set; }

        }
    }
}