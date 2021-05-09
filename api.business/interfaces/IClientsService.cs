using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
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