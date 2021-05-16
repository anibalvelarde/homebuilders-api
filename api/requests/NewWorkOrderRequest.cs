using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// RESET request for creating new Work Orders
    /// </summary>
    public class NewWorkOrderRequest
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public NewWorkOrderRequest() { }
        /// <summary>
        /// Builder to associate to a new WorkOrder
        /// </summary>
        /// <value></value>
        public HomeBuilder Builder { get; set; }
        /// <summary>
        /// WorkOrder to be assigned to an existing Builder
        /// </summary>
        /// <value></value>
        public WorkOrder NewJob { get; set; }
    }
}