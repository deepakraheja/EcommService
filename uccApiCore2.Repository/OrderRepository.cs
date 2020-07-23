﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uccApiCore2.Entities;
using uccApiCore2.Repository.Interface;
using static System.Data.CommandType;

namespace uccApiCore2.Repository
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public async Task<int> SaveOrder(Order obj)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserID", obj.UserID);
                parameters.Add("@FName", obj.FName);
                parameters.Add("@LName", obj.LName);
                parameters.Add("@CompanyName", obj.CompanyName);
                parameters.Add("@Address", obj.Address);
                parameters.Add("@City", obj.City);
                parameters.Add("@State", obj.State);
                parameters.Add("@ZipCode", obj.ZipCode);
                parameters.Add("@EmailId", obj.EmailId);
                parameters.Add("@Phone", obj.Phone);
                parameters.Add("@Country", obj.Country);
                parameters.Add("@OrderNumber", obj.OrderNumber);
                parameters.Add("@OrderDate", obj.OrderDate);
                parameters.Add("@PaymentTypeId", obj.PaymentTypeId);
                parameters.Add("@Notes", obj.Notes);
                parameters.Add("@StatusId", obj.StatusId);
                parameters.Add("@SubTotal", obj.SubTotal);
                parameters.Add("@Tax", obj.Tax);
                parameters.Add("@ShippingCharge", obj.ShippingCharge);
                parameters.Add("@TotalAmount", obj.TotalAmount);
                var res = await SqlMapper.ExecuteScalarAsync(con, "p_SaveOrder", param: parameters, commandType: StoredProcedure);
                return Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<List<Order>> GetOrderByOrderId(Order obj)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@OrderId", obj.OrderId);
                List<Order> lst = (await SqlMapper.QueryAsync<Order>(con, "p_GetOrderByOrderId", param: parameters, commandType: StoredProcedure)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<List<Order>> GetOrderDetailsByOrderId(Order obj)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@OrderId", obj.OrderId);
                List<Order> lst = (await SqlMapper.QueryAsync<Order>(con, "p_GetOrderDetailsByOrderId", param: parameters, commandType: StoredProcedure)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<List<Order>> GetOrderByUserId(Order obj)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserID", obj.UserID);
                List<Order> lst = (await SqlMapper.QueryAsync<Order>(con, "p_GetOrderByUserId", param: parameters, commandType: StoredProcedure)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<List<Order>> GetOrderDetailsByUserId(Order obj)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserID", obj.UserID);
                List<Order> lst = (await SqlMapper.QueryAsync<Order>(con, "p_GetOrderDetailsByUserId", param: parameters, commandType: StoredProcedure)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
