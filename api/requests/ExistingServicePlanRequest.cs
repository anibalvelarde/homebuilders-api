using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingServicePlanRequest
    {
        public ServicePlan ServicePlanToUpdate { get; set; }
    }
}