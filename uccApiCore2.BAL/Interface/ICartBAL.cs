﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface ICartBAL
    {
        Task<int> AddToCart(Cart obj);
        Task<List<Cart>> DelCartById(Cart obj);
        Task<List<Cart>> GetCartById(Cart obj);
    }
}