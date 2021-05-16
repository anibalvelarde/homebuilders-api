using api.business.interfaces;
using api.domain.models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace api.business.services
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