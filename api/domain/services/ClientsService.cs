using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
{
    public class ClientsService : IClientsService
    {
        public Task<Client> AddNewClientAsync(Client prospect)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateExistingClient(Client clientToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}