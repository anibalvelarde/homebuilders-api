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
    public class RegistrationsController : ControllerBase
    {
        // TODO: Replace this Dictionary with a Repository Pattern
        private Dictionary<string, Registration> _registrations = new Dictionary<string, Registration>();

        [HttpPost]
        public ActionResult<Registration> RegisterBuilder([FromBody] Registration prospect)
        {
            if (_registrations.ContainsKey(prospect.Name))
            {
                return _registrations.First(p => p.Key.Equals(prospect.Name)).Value;
            }
            else
            {
                var r = Registration.RegisterProspect(prospect);
                _registrations.Add(r.Name, r);
                return r;
            }
        }
    }
}