using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
   public class Description
    {

        public int DescID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public virtual DrugDetail DrugDetail { get; set; }
        public virtual TreatmentDetail TreatmentDetail { get; set; }
        public virtual ICollection<Doctor> DoctorID { get; set; }
        public virtual ICollection<OPDPatient> PatientID { get; set; }
        public virtual ICollection<Record> RecordID { get; set; }
    }
}
