using OpenQbit.Hospital.Common.Models.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IRoomDetailsManager
    {
        bool RecoredRoomDetails(RoomDetails RoomDetails);
        bool EditRoomDetails(RoomDetails RoomDetails);
        bool DeleteRoomDetails(RoomDetails RoomDetails);
        List<RoomDetails> GetAllRoomDetails();
        RoomDetails FindRoomDetails(RoomDetails RoomDetails);
        List<RoomDetails> FindRoomDetails(List<RoomDetails> RoomDetails);
    }
}
