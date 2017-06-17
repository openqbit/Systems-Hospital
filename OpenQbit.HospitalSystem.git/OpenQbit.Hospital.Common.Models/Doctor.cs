using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OpenQbit.Hospital.Common.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        public int EmployeeId { get; set; }
        public virtual Management.Employee Employee { get; set; }

    }
}
