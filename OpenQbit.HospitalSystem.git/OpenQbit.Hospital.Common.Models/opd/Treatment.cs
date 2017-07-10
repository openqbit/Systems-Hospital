using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
    public class Treatment
    {
        public int TreatmentID { get; set; }
        public string type { get; set; }

        public virtual TreatmentDetail TreatmentDetail { get; set; }
    }
}
