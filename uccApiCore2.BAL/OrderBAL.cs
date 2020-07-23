﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.BAL.Interface;
using uccApiCore2.Entities;
using uccApiCore2.Repository.Interface;

namespace uccApiCore2.BAL
{
    public class OrderBAL : IOrderBAL
    {
        IOrderRepository _OrderRepository;

        public OrderBAL(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public Task<int> SaveOrder(Order obj)
        {
            return _OrderRepository.SaveOrder(obj);
        }
        public Task<List<Order>> GetOrderByOrderId(Order obj)
        {
            return _OrderRepository.GetOrderByOrderId(obj);
        }
        public Task<List<Order>> GetOrderDetailsByOrderId(Order obj)
        {
            return _OrderRepository.GetOrderDetailsByOrderId(obj);
        }
        public Task<List<Order>> GetOrderByUserId(Order obj)
        {
            return _OrderRepository.GetOrderByUserId(obj);
        }
        public Task<List<Order>> GetOrderDetailsByUserId(Order obj)
        {
            return _OrderRepository.GetOrderDetailsByUserId(obj);
        }
    }
}
