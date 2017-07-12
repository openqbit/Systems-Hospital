using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
   public class Appointment
    {
        public int AppointmentID { get; set; }
        public String Date { get; set; }
        public string Time { get; set; }

        public virtual ICollection<OPDPatient> Patient { get; set; }
        public virtual ICollection<Room> Room { get; set; }
    }
}
