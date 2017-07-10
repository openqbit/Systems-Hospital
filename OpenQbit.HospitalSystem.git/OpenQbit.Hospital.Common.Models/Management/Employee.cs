using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Management
{
    public class Employee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public int GradeId { get; set; }
        public int RoleId { get; set; }
        public int BankId { get; set; }
        public string BankAccount { get; set; }
        public DateTime JoinedDate { get; set; }


        public virtual Person Person { get; set; }
    }
}
