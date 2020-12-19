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
    [Route("/api/[controller]")]
    public class HomeBuildersController : ControllerBase
    {
        private List<HomeBuilder> _builders = null;

        private readonly ILogger<HomeBuildersController> _logger;

        public HomeBuildersController(ILogger<HomeBuildersController> logger) => _logger = logger;

        [HttpPost]
        public async Task<ActionResult<HomeBuilder>> CreateBuilder([FromBody] HomeBuilder createBuilder)
        {
            foreach (var hdr in Request.Headers)
            {
                Console.WriteLine($"Request: [{hdr.Key.ToString()}]: - - -> {hdr.Value.ToString()}");
            }
            var aBuilder = GetFakeHomeBuilders().FirstOrDefault(b => b.BbbId.Equals(createBuilder.BbbId));
            if (aBuilder is null)
            {
                var wellFormedBuilder = await Task.FromResult(new HomeBuilder(_builders.Count, createBuilder));
                _builders.Add(wellFormedBuilder);
                return new OkObjectResult(wellFormedBuilder);
            }
            return new BadRequestObjectResult(createBuilder);
        }

        [HttpGet]
        public IEnumerable<HomeBuilder> Get()
        {
            return GetFakeHomeBuilders();
        }

        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult<HomeBuilder> Get(int id)
        {
            var homeBuilder = GetFakeHomeBuilders().FirstOrDefault(s => s.Id.Equals(id));
            if (homeBuilder is null)
            {
                return new NotFoundObjectResult(new HomeBuilder(id));
            }
            return homeBuilder;
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
