using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiRoom
    {
        public string RoomID { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
    }
}