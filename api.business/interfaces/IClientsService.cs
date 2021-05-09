using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;

namespace api.business.interfaces
{
    public interface IClientsService
    {
        Task<List<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(Guid id);
        Task<Client> AddNewClientAsync(Client prospect);
        Task<Client> UpdateExistingClientAsync(Client clientToUpdate);


        Task<List<Client>> GetClientsForHomeBuilderAsync(int homeBuilderId);
    }
}