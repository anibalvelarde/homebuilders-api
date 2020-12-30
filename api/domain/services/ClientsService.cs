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
            var newClient = new Client(prospect);
            return Task.FromResult(newClient);
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            return Task.FromResult(MakeFakeClient(id));
        }

        public Task<List<Client>> GetClientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetClientsForHomeBuilderAsync(int homeBuilderId)
        {
            var clients = new List<Client>();
            for (int i = 0; i < 5; i++)
            {
                clients.Add(MakeFakeClient(i));
            }
            return Task.FromResult(clients);
        }

        public Task<Client> UpdateExistingClientAsync(Client clientToUpdate)
        {
            throw new NotImplementedException();
        }

        private Client MakeFakeClient(int fakeBuilderId)
        {
            return new Client()
            {
                Name = $"Fake name {fakeBuilderId}",
                Address = $"Fake address for ID: {fakeBuilderId}",
                Email = $"email-{fakeBuilderId}@server-{fakeBuilderId}.com",
                Phone = $"867-5{fakeBuilderId}-5309",
                WebAddress = $"www.server-{fakeBuilderId}.com"

            };
        }
    }
}