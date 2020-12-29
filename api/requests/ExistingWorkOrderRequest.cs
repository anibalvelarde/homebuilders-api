using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingWorkOrderRequest
    {
        public WorkOrder WorkOrderToUpdate { get; set; }
    }
}