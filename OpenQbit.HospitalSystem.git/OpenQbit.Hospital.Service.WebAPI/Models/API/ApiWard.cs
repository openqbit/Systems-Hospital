using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiWard
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int InchargeID { get; set; }
        [ForeignKey("InchargeID")]
        public virtual ApiEmployee ApiEmplyee { get; set; }
        public int ApiWardTypeId { get; set; }
        public virtual ApiWardType ApiWardType { get; set; }
    }
}