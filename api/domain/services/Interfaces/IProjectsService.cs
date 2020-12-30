using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IProjectsService
    {
        Task<List<Project>> GetProjectsAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task<Project> AddNewProjectAsync(Project prospect);
        Task<Project> UpdateExistingProjectAsync(Project ProjectToUpdate);
        Task<List<Project>> GetProjectsForHomeBuilderAsync(int id);
    }
}