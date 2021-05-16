using api.business.interfaces;
using api.domain.models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using api.data.interfaces;

namespace api.business.services
{
    public class ClientsService : IClientsService
    {
        private readonly IClientDataProvider _dataProvider;
        public ClientsService(IClientDataProvider provider)
        {
            _dataProvider = provider;
        }

        public async Task<Client> AddNewClientAsync(Client prospect)
        {
            Client newClient = await _dataProvider.AddClient(prospect);
            return newClient;
        }

        public async Task<Client> GetClientByIdAsync(Guid id)
        {
            return await _dataProvider.FetchClientByIdAsync(id);
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            return await _dataProvider.FetchAllClientsAsync();
        }

        public async Task<IEnumerable<Client>> SearchClientByNameAsync(string namePattern)
        {
            return await _dataProvider.SearchClientsByNameAsync(namePattern);
        }


        public Task<List<Client>> GetClientsForHomeBuilderAsync(int homeBuilderId)
        {
            var clients = new List<Client>();
            for (int i = 0; i < 5; i++)
            {
                clients.Add(MakeFakeClient(i + 1));
            }
            return Task.FromResult(clients);
        }

        public async Task<Client> UpdateExistingClientAsync(Guid id, Client clientToUpdate)
        {
            return await _dataProvider.UpdateExistingClient(id, clientToUpdate);
        }

        private Client MakeFakeClient(int fakeBuilderId)
        {
            var aClient = new Client()
            {
                Name = $"Fake name {fakeBuilderId}",
                Address = $"Fake address for ID: {fakeBuilderId}",
                Email = $"email-{fakeBuilderId}@server-{fakeBuilderId}.com",
                Phone = $"867-5{fakeBuilderId}-5309",
                WebAddress = $"www.server-{fakeBuilderId}.com"
            };
            return new Client(aClient);
        }

        public async Task<Client> DeleteExistingClientAsync(Guid id)
        {
            return await _dataProvider.DeleteClientByIdAsync(id);
        }
    }
}