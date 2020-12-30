using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;
using HomeBuilders.Api.Domain.Models.Enums;

namespace HomeBuilders.Api.Services
{
    public class ProjectsService : IProjectsService
    {
        private readonly IClientsService _clientService;
        private readonly IEmployeesService _employeeService;

        public ProjectsService(IClientsService clientService, IEmployeesService empService)
        {
            _clientService = clientService;
            _employeeService = empService;
        }

        public Task<Project> AddNewProjectAsync(Project prospect, HomeBuilder builder, Client owner)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Project> UpdateExistingProjectAsync(Project ProjectToUpdate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Project>> GetProjectsForHomeBuilderAsync(int builderId)
        {
            var projects = new List<Project>();
            for (int i = 0; i < 5; i++)
            {
                projects.Add(await MakeFakeProject(i));
            }
            return projects;
        }

        private async Task<Project> MakeFakeProject(int id)
        {
            return new Project()
            {
                TemplateReferenceId = Guid.NewGuid(),
                Type = ProjectType.Lodging,
                Status = ProjectStatus.Organizing,
                FinancingBy = $"Wings Financial (ID:{id})",
                Owner = await _clientService.GetClientByIdAsync(id + 3)
            };
        }
    }
}