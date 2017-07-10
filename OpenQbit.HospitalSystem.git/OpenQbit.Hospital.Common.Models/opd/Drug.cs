using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
   public class Drug
    {
        public int DrugID { get; set; }
        public string name { get; set; }
        public virtual DrugDetail DrugDetail { get; set; }
    }
}
