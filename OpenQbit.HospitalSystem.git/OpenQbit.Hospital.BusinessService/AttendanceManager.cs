using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Management;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;

namespace OpenQbit.Hospital.BusinessService
{
    public class AttendanceManager : IAttendanceManager
    {
        private ILogger _log;
        private IRepository _repository;
        public AttendanceManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool EditAttendance(Attendance attendance)
        {
            _log.LogError("");
            return _repository.Update<Attendance>(attendance);
        }

        public Attendance FindAttendance(Attendance attendance)
        {
            _log.LogError("");
            return _repository.Find<Attendance>(A => A.Id == attendance.Id);
        }

        public List<Attendance> GetAllAttendance()
        {
            _log.LogError("");
            return _repository.GetAll<Attendance>();
        }

        public bool RecoredAttendance(Attendance attendance)
        {
            _log.LogError("");
            return _repository.Create<Attendance>(attendance);
        }

        public bool RemoveAttendance(Attendance attendance)
        {
            _log.LogError("");
            return _repository.Delete<Attendance>(attendance);
        }
    }
}
