using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
{
    public class ServicePlansService : IServicePlansService
    {
        public Task<ServicePlan> AddNewServicePlanAsync(ServicePlan prospect)
        {
            throw new NotImplementedException();
        }

        public Task<ServicePlan> GetServicePlanByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServicePlan>> GetServicePlansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServicePlan> UpdateExistingServicePlanAsync(ServicePlan ServicePlanToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}