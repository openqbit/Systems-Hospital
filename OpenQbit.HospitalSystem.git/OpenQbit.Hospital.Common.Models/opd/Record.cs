using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
    public class Record
    {
        public int RecID { get; set; }
        public virtual ICollection<OPDPatient> PatientID { get; set; }
        public virtual Description Description { get; set; }
    }
}
