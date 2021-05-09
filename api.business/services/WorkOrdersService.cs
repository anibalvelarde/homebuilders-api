using api.business.interfaces;
using api.domain.models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace api.business.services
{
    public class WorkOrdersService : IWorkOrdersService
    {
        public Task<WorkOrder> AddNewWorkOrderAsync(WorkOrder prospect)
        {
            throw new NotImplementedException();
        }

        public Task<WorkOrder> GetWorkOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkOrder>> GetWorkOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkOrder>> GetWorkOrdersForBuilderAsync(int id)
        {
            var workOrders = new List<WorkOrder>();
            for (int i = 0; i < 5; i++)
            {
                workOrders.Add(MakeFakeWorkOrder(i));
            }
            return Task.FromResult(workOrders);
        }

        public Task<WorkOrder> UpdateExistingWorkOrderAsync(WorkOrder WorkOrderToUpdate)
        {
            throw new NotImplementedException();
        }

        private WorkOrder MakeFakeWorkOrder(int id)
        {
            return new WorkOrder(Guid.NewGuid())
            {
                Description = $"Please, work on this issue {id}"
            };
        }

    }
}