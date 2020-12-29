using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewProjectRequest
    {
        public NewProjectRequest() { }
        public Project Prospect { get; set; }
    }
}