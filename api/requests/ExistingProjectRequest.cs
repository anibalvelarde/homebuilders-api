using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// RESET request for Project
    /// </summary>
    public class ExistingProjectRequest
    {
        /// <summary>
        /// Project resource to update
        /// </summary>
        /// <value></value>
        public Project ProjectToUpdate { get; set; }
    }
}