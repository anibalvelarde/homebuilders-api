using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;

namespace api.business.interfaces
{
    public interface IServicePlansService
    {
        Task<List<ServicePlan>> GetServicePlansAsync();
        Task<ServicePlan> GetServicePlanByIdAsync(int id);
        Task<ServicePlan> AddNewServicePlanAsync(ServicePlan prospect);
        Task<ServicePlan> UpdateExistingServicePlanAsync(ServicePlan ServicePlanToUpdate);
    }
}