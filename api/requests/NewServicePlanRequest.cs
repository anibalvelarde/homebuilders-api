using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for creating a new Service Plan
    /// </summary>
    public class NewServicePlanRequest
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public NewServicePlanRequest() { }
        /// <summary>
        /// Builder resource to be associated to a platform service plan
        /// </summary>
        /// <value></value>
        public HomeBuilder Builder { get; set; }
        /// <summary>
        /// Service Plan resource assoicated to the Builder
        /// </summary>
        /// <value></value>
        public ServicePlan NewPlan { get; set; }
    }
}