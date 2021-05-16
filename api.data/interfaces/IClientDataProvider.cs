using System.Threading.Tasks;
using System.Collections.Generic;
using api.domain.models;
using System;

namespace api.data.interfaces
{
    public interface IClientDataProvider
    {
        Task<List<Client>> FetchAllClientsAsync();
        Task<Client> FetchClientByIdAsync(Guid id);
        Task<IEnumerable<Client>> SearchClientsByNameAsync(string namePattern);
        Task<Client> AddClient(Client prospect);
        Task<Client> DeleteClientByIdAsync(Guid id);
        Task<Client> UpdateExistingClient(Guid id, Client clientToUpdate);
    }
}