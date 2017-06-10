using OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models;
using OpenQbit.Hospital.Presentation.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    public class Orders
    {
        public int OrderID { get; set; }

        public DateTime Time { get; set; }

        public DateTime date { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }

    }
}