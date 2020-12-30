using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingEmployeeRequest
    {
        public Employee EmployeeToUpdate { get; set; }
    }
}