using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IHomeBuildersService
    {
        Task<IEnumerable<HomeBuilder>> GetHomeBuilderList();
        Task<HomeBuilder> GetHomeBuilderById(int id);
    }
}