using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for a new Employee who joins a HomeBuilder
    /// </summary>
    public class NewEmployeeRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NewEmployeeRequest() { }
        /// <summary>
        /// HomeBuilder resource to assoicate to an Employee
        /// </summary>
        /// <value></value>
        public HomeBuilder Builder { get; set; }
        /// <summary>
        /// Employee resource to associate to a Home Builder
        /// </summary>
        /// <value></value>
        public Employee NewHire { get; set; }
    }
}