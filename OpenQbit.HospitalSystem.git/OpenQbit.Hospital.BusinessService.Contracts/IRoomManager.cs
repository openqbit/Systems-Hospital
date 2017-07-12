using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IRoomManager
    {
        bool RecoredRoom(Room room);

        bool UpdataRoom(Room room);

        bool RemoveRoom(Room room);

        Room SearchRoom(String RoomID);

        Array AllRoom();
    }
}
