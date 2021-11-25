﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;

namespace ItechArtLabPetsitters.Core.ServiceCore.Order
{
    public interface IOrdersService
    {
        public Task CreateClientOrderAsync(OrderModel model);
        public Task DeleteOrderAsync(long OrderID);
        public Task TakeDoerOrderAsync(long OrderID, long DoerID);
        public Task CancelDoerOrderAsync(long OrderID);
    }
}