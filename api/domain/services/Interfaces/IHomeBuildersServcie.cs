using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IHomeBuildersService
    {
        Task<IEnumerable<HomeBuilder>> GetHomeBuilderList();
        Task<HomeBuilder> GetHomeBuilderById(int id);
        Task<List<Client>> GetClientsForBuilder(int id);
        Task<List<Project>> GetProjectsForBuilder(int id);
        Task<List<Employee>> GetEmployeesForBuilder(int id);
        Task<ServicePlan> GetServicePlansForBuilder(int id);
        Task<Stats> GetStatsForBuilder(int id);
        Task<List<WorkOrder>> GetPendingWorkOrdersForBuilder(int id);
    }
}