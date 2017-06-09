using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models
{
    public class Category
    {
        public int categoryID { get; set; }

        public String categoryName { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}