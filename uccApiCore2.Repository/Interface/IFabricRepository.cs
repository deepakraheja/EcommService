﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.Repository.Interface
{
    public interface IFabricRepository
    {
        Task<List<Fabric>> GetFabric(Fabric obj);
        Task<List<Fabric>> GetAllFabric(Fabric obj);
        Task<int> SaveFabric(Fabric obj);
    }
}
