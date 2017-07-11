using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Service.WebAPI.Models.API
{
    public class ApiWardAdmition
    {
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Description { get; set; }
        //public int RoomDetailsID { get; set; }
        //public virtual RoomDetails RoomDetails { get; set; }
        public int RoomID { get; set; }
        public virtual ApiRoom Room { get; set; }
        public int PatientID { get; set; }
        public virtual ApiPatient Patient { get; set; }
    }
}