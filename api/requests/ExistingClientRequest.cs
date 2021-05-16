using api.domain.models;

namespace HomeBuilders.Api.Requests
{
    /// <summary>
    /// REST Request for updating a client
    /// </summary>
    public class ExistingClientRequest
    {
        /// <summary>
        /// Client resource that will be updated
        /// </summary>
        /// <value></value>
        public Client ClientToUpdate { get; set; }
    }
}