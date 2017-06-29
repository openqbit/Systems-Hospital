﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }

        public int RefID { get; set; }

        // need Dynamic objects
        

    }

    public enum ItemType { Pharmacy, Ward, OPD}
}
