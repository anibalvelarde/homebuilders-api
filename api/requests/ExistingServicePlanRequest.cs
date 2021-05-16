using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for Service Plan
    /// </summary>
    public class ExistingServicePlanRequest
    {
        /// <summary>
        /// Service Plan resource to update
        /// </summary>
        /// <value></value>
        public ServicePlan ServicePlanToUpdate { get; set; }
    }
}