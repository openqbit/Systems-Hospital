using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
   public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PatientCount { get; set; }

        public virtual Description Description { get; set; }
        public virtual Room Room { get; set; }

    }
}
