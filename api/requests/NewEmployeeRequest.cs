using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewEmployeeRequest
    {
        public NewEmployeeRequest() { }
        public Employee NewHire  { get; set; }
    }
}