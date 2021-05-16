using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;

namespace api.business.interfaces
{
    public interface IProjectsService
    {
        Task<List<Project>> GetProjectsAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task<Project> AddNewProjectAsync(Project prospect, HomeBuilder builder, Client owner);
        Task<Project> UpdateExistingProjectAsync(Project ProjectToUpdate);
        Task<List<Project>> GetProjectsForHomeBuilderAsync(int id);
    }
}