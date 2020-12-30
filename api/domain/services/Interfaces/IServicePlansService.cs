using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IServicePlansService
    {
        Task<List<ServicePlan>> GetServicePlansAsync();
        Task<ServicePlan> GetServicePlanByIdAsync(int id);
        Task<ServicePlan> AddNewServicePlanAsync(ServicePlan prospect);
        Task<ServicePlan> UpdateExistingServicePlanAsync(ServicePlan ServicePlanToUpdate);
    }
}