using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingServicePlanRequest
    {
        public ServicePlan ServicePlanToUpdate { get; set; }
    }
}