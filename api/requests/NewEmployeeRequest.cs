using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class NewEmployeeRequest
    {
        public NewEmployeeRequest() { }
        public Employee Prospect { get; set; }
    }
}