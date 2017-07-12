using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IDoctorManager
    {
        bool RecoredDoctor(Doctor doctor);

        bool UpdataDoctor(Doctor doctor);

        bool RemoveDoctor(Doctor doctor);

        Doctor SearchDoctors(String doctorID);

        Array AllDoctors();
    }
}
