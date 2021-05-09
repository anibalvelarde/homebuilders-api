using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;

namespace api.business.interfaces
{
    public interface IWorkOrdersService
    {
        Task<List<WorkOrder>> GetWorkOrdersAsync();
        Task<WorkOrder> GetWorkOrderByIdAsync(int id);
        Task<WorkOrder> AddNewWorkOrderAsync(WorkOrder prospect);
        Task<WorkOrder> UpdateExistingWorkOrderAsync(WorkOrder WorkOrderToUpdate);
        Task<List<WorkOrder>> GetWorkOrdersForBuilderAsync(int id);
    }
}