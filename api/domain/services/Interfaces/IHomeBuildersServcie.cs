using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IHomeBuildersService
    {
        Task<IEnumerable<HomeBuilder>> GetHomeBuilderListAsync();
        Task<HomeBuilder> GetHomeBuilderByIdAsync(int id);
        Task<List<Client>> GetClientsForBuilderAsync(int id);
        Task<List<Project>> GetProjectsForBuilderAsync(int id);
        Task<List<Employee>> GetEmployeesForBuilderAsync(int id);
        Task<ServicePlan> GetServicePlansForBuilderAsync(int id);
        Task<Stats> GetStatsForBuilderAsync(int id);
        Task<List<WorkOrder>> GetPendingWorkOrdersForBuilderAsync(int id);
    }
}