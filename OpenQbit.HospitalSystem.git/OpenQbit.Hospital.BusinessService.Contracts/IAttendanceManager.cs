using OpenQbit.Hospital.Common.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IAttendanceManager
    {
        bool RecoredAttendance(Attendance attendance);
        bool EditAttendance(Attendance attendance);
        bool RemoveAttendance(Attendance attendance);
        List<Attendance> GetAllAttendance();
        Attendance FindAttendance(Attendance attendance);
    }
}
