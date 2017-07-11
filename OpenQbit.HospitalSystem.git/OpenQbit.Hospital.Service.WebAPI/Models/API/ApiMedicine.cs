
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    namespace OpenQbit.Hospital.Common.Models.Phamarcy
    {
        public class ApiMedicine
        {
            public int ID { get; set; }
            public int GenricName { get; set; }
            public virtual ICollection<ApiDrug> Drug { get; set; }
        }
    }

}
