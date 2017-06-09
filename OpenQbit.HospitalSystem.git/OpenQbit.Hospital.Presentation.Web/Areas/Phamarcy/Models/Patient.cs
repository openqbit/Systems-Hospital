using OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Models
{
    public class Patient
    {
        public int PID { get; set; }
        public String PatientName { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}