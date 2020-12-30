using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
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

        [HttpGet]
        [Route("/clients")]
        public async Task<List<Client>> GetClientsAsync()
        {
            return await _service.GetClientsAsync();
        }

        [HttpGet]
        [Route("/clients/{id}")]
        public async Task<Client> GetClientById(int id)
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
        [Route("/clients")]
        public async Task<Client> UpdateExistingClient([FromBody] ExistingClientRequest clientRequest)
        {
            return await _service.UpdateExistingClientAsync(clientRequest.ClientToUpdate);
        }
    }
}