using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController
    {
        private ILogger<ProjectsController> _logger;
        private IProjectsService _service;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectsService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("/projects")]
        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _service.GetProjectsAsync();
        }

        [HttpGet]
        [Route("/projects/{id}")]
        public async Task<Project> GetProjectById(int id)
        {
            return await _service.GetProjectByIdAsync(id);
        }

        [HttpPost]
        [Route("/projects")]
        public async Task<Project> AddNewProject([FromBody] NewProjectRequest ProjectRequest)
        {
            return await _service.AddNewProjectAsync(ProjectRequest.NewGig);
        }

        [HttpPut]
        [Route("/projects")]
        public async Task<Project> UpdateExistingProject([FromBody] ExistingProjectRequest ProjectRequest)
        {
            return await _service.UpdateExistingProjectAsync(ProjectRequest.ProjectToUpdate);
        }
    }
}