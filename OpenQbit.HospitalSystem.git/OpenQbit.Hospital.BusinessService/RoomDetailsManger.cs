using OpenQbit.Hospital.BusinessService.Contracts;
using OpenQbit.Hospital.Common.Models.Ward;
using OpenQbit.Hospital.Common.Utils.Logs;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService
{
    class RoomDetailsManger : IRoomDetailsManager
    {
        private IRepository _repository;

        private ILogger _log;


        public RoomDetailsManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredRoomDetails(RoomDetails RoomDetails)
        {
            _log.LogError("");
           return _repository.Create<RoomDetails>(RoomDetails);
        }

        public bool EditRoomDetails(RoomDetails RoomDetails)
        {
            _log.LogError("");
            return _repository.Update<RoomDetails>(RoomDetails);
        }

        public bool DeleteRoomDetails(RoomDetails RoomDetails)
        {
            _log.LogError("");
            return _repository.Delete<RoomDetails>(RoomDetails);
        }

        public List<RoomDetails> GetAllRoomDetails()
        {
            _log.LogError("");
            return _repository.GetAll<RoomDetails>();
        }

        public RoomDetails FindRoomDetails(RoomDetails RoomDetails)
        {
            _log.LogError("");
            return _repository.Find<RoomDetails>(R => R.ID == RoomDetails.ID);
        }
    }
}
