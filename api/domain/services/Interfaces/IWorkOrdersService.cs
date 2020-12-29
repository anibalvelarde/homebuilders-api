using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IWorkOrdersService
    {
        Task<List<WorkOrder>> GetWorkOrdersAsync();
        Task<WorkOrder> GetWorkOrderByIdAsync(int id);
        Task<WorkOrder> AddNewWorkOrderAsync(WorkOrder prospect);
        Task<WorkOrder> UpdateExistingWorkOrder(WorkOrder WorkOrderToUpdate);
    }
}