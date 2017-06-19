using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DOB { get; set; }

        public string GlobalId { get; set; }


    }
}
