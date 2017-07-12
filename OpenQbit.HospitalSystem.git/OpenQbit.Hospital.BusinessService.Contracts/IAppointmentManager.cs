using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IAppointmentManager
    {
        bool RecoredAppointment(Appointment appointment);

        bool UpdataAppointment(Appointment appointment);

        bool RemoveAppointment(Appointment appoimtment);

        Appointment SearchAppointment(String appointmentID);

        Array AllAppointment();

    }
}
