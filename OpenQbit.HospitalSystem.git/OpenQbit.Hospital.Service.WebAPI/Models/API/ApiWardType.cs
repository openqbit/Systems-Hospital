using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiWardType
    {
        public int WardTypeId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
    }
}