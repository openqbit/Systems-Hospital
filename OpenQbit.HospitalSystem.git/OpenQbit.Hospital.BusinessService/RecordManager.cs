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
    public class RecordManager : IRecordManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  RecordManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllRecord()
        {
            throw new NotImplementedException();
        }

        public bool RecoredRecordsl(Record record)
        {
            _log.LogError("");

            return _repository.Create<Record>(record);
        }

        public bool RemoveRecord(Record record)
        {
            _log.LogError("");

            return _repository.Delete<Record>(record);
        }

        public Record SearchRecord(string recordID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataRecord(Record record)
        {
            _log.LogError("");

            return _repository.Update<Record>(record);
        }
    }
}
