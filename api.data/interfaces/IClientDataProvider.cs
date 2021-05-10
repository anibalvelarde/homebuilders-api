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
    }
}