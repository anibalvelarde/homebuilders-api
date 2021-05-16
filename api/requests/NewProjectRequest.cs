using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request to manage new Project resources
    /// </summary>
    public class NewProjectRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NewProjectRequest() { }
        /// <summary>
        /// HomeBuilder resource that will work on the project
        /// </summary>
        /// <value></value>
        public HomeBuilder Builder { get; set; }
        /// <summary>
        /// Client resource who owns the work-product of the project
        /// </summary>
        /// <value></value>
        public Client ProjectOwner { get; set; }
        /// <summary>
        /// Project resource to be performed
        /// </summary>
        /// <value></value>
        public Project NewGig { get; set; }
    }
}