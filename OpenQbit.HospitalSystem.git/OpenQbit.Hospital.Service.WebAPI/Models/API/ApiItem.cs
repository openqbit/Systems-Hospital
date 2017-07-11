using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }

        public int RefID { get; set; }
    }
    public enum ItemType { Pharmacy, Ward, OPD }
}