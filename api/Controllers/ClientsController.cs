using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
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

        public ClientsController(ILogger<ClientsController> logger, IClientsService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets all the clients in the system. 
        /// </summary>
        /// <returns>List of <c>Client</c> elements.</returns>
        [HttpGet]
        [Route("/clients")]
        public async Task<List<Client>> GetClientsAsync()
        {
            return await _service.GetClientsAsync();
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

        [HttpPost]
        [Route("/clients")]
        public async Task<Client> AddNewClient([FromBody] NewClientRequest clientRequest)
        {
            return await _service.AddNewClientAsync(clientRequest.Prospect);
        }

        [HttpPut]
        [Route("/clients/{di}")]
        public async Task<Client> UpdateExistingClient([FromBody] ExistingClientRequest clientRequest)
        {
            return await _service.UpdateExistingClientAsync(clientRequest.ClientToUpdate);
        }
    }
}