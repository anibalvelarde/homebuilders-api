using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST request for a new Client
    /// </summary>
    public class NewClientRequest
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public NewClientRequest() { }
        /// <summary>
        /// HomeBuilder resource to associate to a client
        /// </summary>
        /// <value></value>
        public HomeBuilder Builder { get; set; }
        /// <summary>
        /// Client Prospect resource to associate to a Home Builder
        /// </summary>
        /// <value></value>
        public Client Prospect { get; set; }
    }
}