using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingClientRequest
    {
        public Client ClientToUpdate { get; set; }
    }
}