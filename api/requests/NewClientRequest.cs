using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewClientRequest
    {
        public NewClientRequest() { }
        public Client Prospect { get; set; }
    }
}