using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomeBuilders.Api.Services.Interfaces;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeBuildersController : ControllerBase
    {
        private IHomeBuildersService _hbService;
        private readonly ILogger<HomeBuildersController> _logger;

        public HomeBuildersController(ILogger<HomeBuildersController> logger, IHomeBuildersService hbService)
        {
            _logger = logger;
            _hbService = hbService;
        }

        [HttpGet]
        [Route("/homebuilders")]
        public async Task<IEnumerable<HomeBuilder>> Get()
        {
            return await _hbService.GetHomeBuilderList();
        }

        [HttpGet]
        [Route("/homebuilders/{id}")]
        public async Task<HomeBuilder> Get(int id)
        {
            return await _hbService.GetHomeBuilderById(id);
        }
    }
}
