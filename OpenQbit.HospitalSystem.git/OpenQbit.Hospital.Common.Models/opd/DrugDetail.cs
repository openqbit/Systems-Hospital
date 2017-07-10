using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.opd
{
   public class DrugDetail
    {
        public string type { get; set; }
        public string brand { get; set; }
        public string Dossage { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public virtual ICollection<Drug> Drug { get; set; }
        public virtual Description Description { get; set; }

    }
}
