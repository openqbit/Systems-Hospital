using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Service.PayrollService.API
{
    public class PersonAPIModal
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string GlobalId { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public int Mobile { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MaritalStatus { get; set; }
    }
}
