﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class OrderCreationModel
    {
        public long serviceID { set; get; }
        public long petID { set; get; }
        public long clientID { set; get; }
        public string comment { set; get; }
    }
}