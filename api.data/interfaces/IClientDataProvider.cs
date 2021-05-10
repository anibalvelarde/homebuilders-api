using System.Threading.Tasks;
using System.Collections.Generic;
using api.domain.models;

namespace api.data.interfaces
{
    public interface IClientDataProvider
    {
        Task<List<Client>> FetchAllClientsAsync();
    }
}