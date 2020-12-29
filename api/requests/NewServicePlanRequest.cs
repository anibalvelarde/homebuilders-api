using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewServicePlanRequest
    {
        public NewServicePlanRequest() { }
        public HomeBuilder Builder { get; set; }
        public ServicePlan NewPlan { get; set; }
    }
}