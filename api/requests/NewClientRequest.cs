using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    public class NewClientRequest
    {
        public NewClientRequest() { }
        public HomeBuilder Builder { get; set; }
        public Client Prospect { get; set; }
    }
}