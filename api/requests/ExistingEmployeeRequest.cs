using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for existing employee
    /// </summary>
    public class ExistingEmployeeRequest
    {
        /// <summary>
        /// Employee resource to update
        /// </summary>
        /// <value></value>
        public Employee EmployeeToUpdate { get; set; }
    }
}