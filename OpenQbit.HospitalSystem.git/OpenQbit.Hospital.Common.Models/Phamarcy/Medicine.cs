using OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
   public  class Medicine
    {
        public int GenericID { get; set; }
        public int GenricName { get; set; }
        public virtual ICollection<Drug> Drug { get; set; }
    }
}
