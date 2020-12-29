using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
{
    public class HomeBuildersService : IHomeBuildersService
    {
        public Task<IEnumerable<HomeBuilder>> GetHomeBuilderList()
        {
            return Task.FromResult(GetFakeHomeBuilders());
        }
        Task<HomeBuilder> IHomeBuildersService.GetHomeBuilderById(int id)
        {
            return Task.FromResult(GetFakeHomeBuilders().First(s => s.Id.Equals(id)));
        }

        private IEnumerable<HomeBuilder> GetFakeHomeBuilders()
        {
            var _builders = new List<HomeBuilder>();
            {
                _builders = new List<HomeBuilder>();
                for (int i = 0; i < 5; i++)
                {
                    _builders.Add(MakeFakeHomeBuilder(i));
                }
            }
            return _builders;
        }

        private HomeBuilder MakeFakeHomeBuilder(int id)
        {
            var dateStamp = DateTime.UtcNow;
            return new HomeBuilder(id)
            {
                Name = $"Builder-{DateTime.Now.ToUniversalTime().ToString()}",
                Address = "some address for builder",
                BbbId = Guid.NewGuid().ToString(),
                WebAddress = $"www.{dateStamp.ToString()}webserver.com",
                Phone = $"555-555-1{DateTime.Now.Millisecond}",
                Email = $"somebuilder@{dateStamp.ToString()}emailserver.com"
            };
        }
    }
}