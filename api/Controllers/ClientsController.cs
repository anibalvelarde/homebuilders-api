using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using api.domain.models;
using HomeBuilders.Api.Requests;
using api.business.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    /// <summary>
    /// Maintains information about Clients
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ClientsController
    {
        private ILogger<ClientsController> _logger;
        private IClientsService _service;

        /// <summary>
        /// API Controller for "clients" REST resource
        /// </summary>
        /// <param name="logger">ILogger implementation</param>
        /// <param name="service">Backend service provider for "client" access services</param>
        public ClientsController(ILogger<ClientsController> logger, IClientsService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets all the clients in the system. 
        /// </summary>
        /// <returns>IEnumerable of <c>Client</c> elements.</returns>
        [HttpGet]
        [Route("/clients")]
        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            var result = await _service.GetClientsAsync();
            return result.AsEnumerable();
        }

        /// <summary>
        /// Gets a single Client from the list of clients in the system.
        /// </summary>
        /// <param name="id">Unique identifier for a Client</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/clients/{id}")]
        public async Task<Client> GetClientById(Guid id)
        {
            return await _service.GetClientByIdAsync(id);
        }

        /// <summary>
        /// Adds a new "client" resource
        /// </summary>
        /// <param name="clientRequest">A well-formed NewClientRequest</param>
        /// <returns>An instance of the client resource that was just recently created</returns>
        [HttpPost]
        [Route("/clients")]
        public async Task<Client> AddNewClient([FromBody] NewClientRequest clientRequest)
        {
            return await _service.AddNewClientAsync(clientRequest.Prospect);
        }

        /// <summary>
        /// Updates all attributes of a client resource
        /// </summary>
        /// <param name="clientRequest">A well-formed ExistingClientRequest</param>
        /// <returns>An instance of the client resource that was just recently udated</returns>
        [HttpPut]
        [Route("/clients/{di}")]
        public async Task<Client> UpdateExistingClient([FromBody] ExistingClientRequest clientRequest)
        {
            return await _service.UpdateExistingClientAsync(clientRequest.ClientToUpdate);
        }
    }
}