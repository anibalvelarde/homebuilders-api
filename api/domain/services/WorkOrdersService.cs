using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
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

        public Task<WorkOrder> UpdateExistingWorkOrder(WorkOrder WorkOrderToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}