using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewProjectRequest
    {
        public NewProjectRequest() { }
        public HomeBuilder Builder { get; set; }
        public Project NewGig { get; set; }
    }
}