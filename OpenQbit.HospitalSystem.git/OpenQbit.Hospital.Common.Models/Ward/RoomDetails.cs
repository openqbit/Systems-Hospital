using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Ward
{
    public class RoomDetails
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        public int WardID { get; set;}
        public virtual Ward Ward { get; set; }

    }
}
