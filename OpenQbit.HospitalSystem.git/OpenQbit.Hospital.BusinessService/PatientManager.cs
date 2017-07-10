using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class PatientManager : IPatientManager
    {
        private IRepository _repository;

        private ILogger _log;
       public PatientManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool DeletePatient(Patient Patient)
        {
            _log.LogError("");
            return _repository.Delete<Patient>(Patient);
        }

        public bool EditPatient(Patient Patient)
        {
            _log.LogError("");
            return _repository.Update<Patient>(Patient);
        }

        public Patient FindPatient(Patient Patient)
        {
            _log.LogError("");
            return _repository.Find<Patient>(P=>P.ID==Patient.ID);
        }

        public List<Patient> FindPatientByName(string patientNamePart)
        {
            _log.LogError("");
            return _repository.FindList<Patient>(p=>p.PatientName.Contains(patientNamePart));
        }

        public List<Patient> GetAllPatient()
        {
            _log.LogError("");

            return _repository.GetAll<Patient>();
        }

        public bool RecoredPatient(Patient patient)
        {
            _log.LogError("");
            return _repository.Create<Patient>(patient);
        }
    }
}
