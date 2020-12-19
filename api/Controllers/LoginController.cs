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
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger) => _logger = logger;

        [HttpPost]
        public ActionResult<bool> Login([FromBody] Creds request)
        {
            var l = request.ToString();
            var someUser = request.UserName; var someToken = Guid.NewGuid().ToString();
            Console.WriteLine($"Call to Login was made with this:{Environment.NewLine}{l}, with User ['{request.UserName}'] and Password ['{request.Password}']");
            return new OkObjectResult("{" + $"\"user\":\"{someUser}\", \"token\":\"{someToken}\"" + "}");
        }

        [HttpGet]
        public ActionResult<bool> HeartBeat()
        {
            Random r = new Random();
            int randomNumber = r.Next(0, 10);
            if (randomNumber < 2)
            {
                return new BadRequestObjectResult(false);
            }
            return new OkObjectResult(true);
        }
    }
}
