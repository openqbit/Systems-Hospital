using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace OpenQbit.Hospital.Common.Models.Ward
{
    public class Ward
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int InchargeID { get; set; }
        [ForeignKey("InchargeID")]
        public virtual Management.Employee Incharge { get; set; }
        public int WardTypeId { get; set; }
        public virtual WardType WardType { get; set; }
    }
}
