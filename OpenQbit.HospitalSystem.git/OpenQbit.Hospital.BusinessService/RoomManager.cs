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
    public class RoomManager : IRoomManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  RoomManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public Array AllRoom()
        {
            throw new NotImplementedException();
        }

        public bool RecoredRoom(Room room)
        {
            _log.LogError("");

            return _repository.Create<Room>(room);
        }

        public bool RemoveRoom(Room room)
        {
            _log.LogError("");

            return _repository.Delete<Room>(room);
        }

        public Room SearchRoom(string RoomID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataRoom(Room room)
        {
            _log.LogError("");

            return _repository.Update<Room>(room);
        }
    }
}
