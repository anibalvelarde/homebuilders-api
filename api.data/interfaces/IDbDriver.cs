using System.Threading.Tasks;

namespace api.data.interfaces
{
    public interface IDbDriver
    {
        Task<T> GetListAsync<T>();
        Task<T> GetItemAsync<T>(string id);
        Task<T> UpdateItemAsync<T>(T item);
        Task DeleteItemAsync(string id);
    }
}