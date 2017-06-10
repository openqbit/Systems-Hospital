using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Phamarcy;

namespace OpenQbit.Hospital.Common.Models
{
    public class PatientAdmition
    {
        public int ID { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<PharmacyOrders> Orders { get; set; }

    }
}
