using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
    public class Room
    {
        public int RoomID { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual ICollection<Doctor> DoctorID { get; set; }
    }
}
