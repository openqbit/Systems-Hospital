using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiEmployee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public int GradeId { get; set; }
        public int RoleId { get; set; }
        public int BankId { get; set; }
        public string BankAccount { get; set; }
        public DateTime JoinedDate { get; set; }
        public virtual ApiPerson Person { get; set; }
    }
}