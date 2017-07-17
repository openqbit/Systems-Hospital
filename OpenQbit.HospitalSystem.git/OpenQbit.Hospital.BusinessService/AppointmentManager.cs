using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.opd;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class AppointmentManager : IAppointmentManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public AppointmentManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllAppointment()
        {
            throw new NotImplementedException();
        }

        public bool RecoredAppointment(Appointment appointment)
        {
            _log.LogError("");

            return _repository.Create<Appointment>(appointment);
        }

        public bool RemoveAppointment(Appointment appoimtment)
        {
            _log.LogError("");

            return _repository.Delete<Appointment>(appoimtment);
        }

        public Appointment SearchAppointment(string appointmentID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataAppointment(Appointment appointment)
        {
            _log.LogError("");

            return _repository.Update<Appointment>(appointment);
        }
    }
}
