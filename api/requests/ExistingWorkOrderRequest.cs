using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingWorkOrderRequest
    {
        public WorkOrder WorkOrderToUpdate { get; set; }
    }
}