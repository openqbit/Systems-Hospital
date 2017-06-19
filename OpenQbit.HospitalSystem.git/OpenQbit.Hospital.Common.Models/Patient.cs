using OpenQbit.Hospital.Common.Models.OpenQbit.Hospital.Common.Models;
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
        public String PatientName { get; set; }
        
        public virtual ICollection<PatientAdmition> PatientAdmition { get; set; }
        

    }
}