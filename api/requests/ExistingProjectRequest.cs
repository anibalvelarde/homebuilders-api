using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingProjectRequest
    {
        public Project ProjectToUpdate { get; set; }
    }
}