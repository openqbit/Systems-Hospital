using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Ward
{
    public class WardAdmition
    {

        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Description { get; set; }
        //public int RoomDetailsID { get; set; }
        //public virtual RoomDetails RoomDetails { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }


    }
}
