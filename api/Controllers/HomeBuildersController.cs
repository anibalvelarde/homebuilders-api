using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeBuildersController : ControllerBase
    {
        private List<HomeBuilder> _builders = null;

        private readonly ILogger<HomeBuildersController> _logger;

        public HomeBuildersController(ILogger<HomeBuildersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/homebuilders")]
        public IEnumerable<HomeBuilder> Get()
        {
            return GetFakeHomeBuilders();
        }

        [HttpGet]
        [Route("/homebuilders/{id}")]
        public HomeBuilder Get(int id)
        {
            return GetFakeHomeBuilders().First(s => s.Id.Equals(id));
        }

        private IEnumerable<HomeBuilder> GetFakeHomeBuilders()
        {
            if (_builders == null)
            {
                _builders = new List<HomeBuilder>();
                for (int i = 0; i < 5; i++)
                {
                    _builders.Add(MakeFakeHomeBuilder(i));
                }
            }
            return _builders.AsEnumerable();
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
