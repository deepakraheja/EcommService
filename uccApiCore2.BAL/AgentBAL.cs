﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.BAL.Interface;
using uccApiCore2.Entities;
using uccApiCore2.Repository.Interface;

namespace uccApiCore2.BAL
{
    public class AgentBAL : IAgentBAL
    {
        IAgentRepository _IAgentRepository;

        public AgentBAL(IAgentRepository IAgentRepository)
        {
            _IAgentRepository = IAgentRepository;
        }
        public Task<int> AgentRegistration(Agents obj)
        {
            return _IAgentRepository.AgentRegistration(obj);
        }
        public Task<int> UpdateAgent(Agents obj)
        {
            return _IAgentRepository.UpdateAgent(obj);
        }
        public Task<List<Agents>> GetAgentInfo(Agents obj)
        {
            return _IAgentRepository.GetAgentInfo(obj);
        }
    }
}
