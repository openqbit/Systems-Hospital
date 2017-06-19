using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Ward
{
    public class Treatment
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int WardAdmitionID { get; set; }
        public virtual WardAdmition WardAdmition { get; set; }
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        


    }
}
