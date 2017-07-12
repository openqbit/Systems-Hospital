using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IOPDPatientManager
    {
        bool RecoredOPDPatient(OPDPatient OPDPatient);

        bool UpdataOPDPatient(OPDPatient OPDPatient);

        bool RemoveOPDPatient(OPDPatient OPDPatient);

        OPDPatient SearchOPDPatient(String OPDPatientID);

        Array AllOPDPatient();
    }
}
