using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;
using HomeBuilders.Api.Requests;
using api.business.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    /// <summary>
    /// Handles management of Project resources
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController
    {
        private ILogger<ProjectsController> _logger;
        private IProjectsService _service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Instance of the Logger service</param>
        /// <param name="service">Instance of the Project Management service</param>
        public ProjectsController(ILogger<ProjectsController> logger, IProjectsService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets a list of Project resources
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/projects")]
        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _service.GetProjectsAsync();
        }

        /// <summary>
        /// Get a single Project resource
        /// </summary>
        /// <param name="id">Unique identifier for a Project resource</param>
        /// <returns>A Project resource instance</returns>
        [HttpGet]
        [Route("/projects/{id}")]
        public async Task<Project> GetProjectById(int id)
        {
            return await _service.GetProjectByIdAsync(id);
        }

        /// <summary>
        /// Creates a new Project resource in the platform
        /// </summary>
        /// <param name="ProjectRequest">Well-formed info set to properly create a Project resource</param>
        /// <returns>The Project resource that was added to the platform</returns>
        [HttpPost]
        [Route("/projects")]
        public async Task<Project> AddNewProject([FromBody] NewProjectRequest ProjectRequest)
        {

            return await _service.AddNewProjectAsync(
                ProjectRequest.NewGig,
                ProjectRequest.Builder,
                ProjectRequest.ProjectOwner
            );
        }

        /// <summary>
        /// Updates an existing Project resource
        /// </summary>
        /// <param name="ProjectRequest">Well-formed info set to properly update a Project resource</param>
        /// <returns></returns>
        [HttpPut]
        [Route("/projects")]
        public async Task<Project> UpdateExistingProject([FromBody] ExistingProjectRequest ProjectRequest)
        {
            return await _service.UpdateExistingProjectAsync(ProjectRequest.ProjectToUpdate);
        }
    }
}