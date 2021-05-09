using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    public class ExistingEmployeeRequest
    {
        public Employee EmployeeToUpdate { get; set; }
    }
}