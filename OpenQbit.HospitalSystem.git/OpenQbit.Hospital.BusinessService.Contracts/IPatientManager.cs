using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IPatientManager
    {
        bool RecoredPatient(Patient patient);
        bool EditPatient(Patient Patient);
        bool DeletePatient(Patient Patient);
        List<Patient> GetAllPatient();
        Patient FindPatient(Patient Patient);
        List<Patient> FindPatientByName(String patientNamePart);
    }
}
