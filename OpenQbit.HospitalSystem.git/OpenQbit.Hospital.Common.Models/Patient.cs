using OpenQbit.Hospital.Common.Models.Phamarcy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string PatientName { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<PatientAdmition> PatientAdmition { get; set; }
        

    }
}