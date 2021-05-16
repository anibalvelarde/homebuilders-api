using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for Work Order 
    /// </summary>
    public class ExistingWorkOrderRequest
    {
        /// <summary>
        /// WorkOrder resource to update
        /// </summary>
        /// <value></value>
        public WorkOrder WorkOrderToUpdate { get; set; }
    }
}