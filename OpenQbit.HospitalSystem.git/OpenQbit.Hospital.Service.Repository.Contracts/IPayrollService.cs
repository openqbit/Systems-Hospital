using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Service.Repository.Contracts
{
    public interface IPayrollService
    {
        // Do not Make Any Change
        Task<Person> GetPerson();
        // methods taken frm payroll
    }
}
