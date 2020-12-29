using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
{
    public class ProjectsService : IProjectsService
    {
        public Task<Project> AddNewProjectAsync(Project prospect)
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

        public Task<Project> UpdateExistingProject(Project ProjectToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}