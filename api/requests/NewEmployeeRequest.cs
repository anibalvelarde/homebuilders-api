using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    public class NewEmployeeRequest
    {
        public NewEmployeeRequest() { }
        public HomeBuilder Builder { get; set; }
        public Employee NewHire { get; set; }
    }
}