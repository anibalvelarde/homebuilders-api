using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewWorkOrderRequest
    {
        public NewWorkOrderRequest() { }
        public HomeBuilder Builder { get; set; }
        public WorkOrder NewJob { get; set; }
    }
}