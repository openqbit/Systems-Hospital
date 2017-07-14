using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Service.PayrollService.Mappers
{
    public static class APIPersonMapper
    {
        public static API.PersonAPIModal MapApiPerson(Common.Models.Person person )
        {
            return new API.PersonAPIModal { FirstName = person.FirstName, LastName = person.LastName };
        }

        public static Person MapPerson(API.PersonAPIModal apiPerson)
        {
            return new  Person { FirstName = apiPerson.FirstName, LastName = apiPerson.LastName };
        }
    }
}
