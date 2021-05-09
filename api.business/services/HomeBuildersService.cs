using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;
using HomeBuilders.Api.Domain.Models.Enums;

namespace HomeBuilders.Api.Services
{
    public class HomeBuildersService : IHomeBuildersService
    {
        private readonly Random _rnd = new Random();
        private readonly IClientsService _clientService;
        private readonly IProjectsService _projectService;
        private readonly IEmployeesService _employeeService;
        private readonly IWorkOrdersService _woService;

        public HomeBuildersService(
            IClientsService clientService,
            IProjectsService projectService,
            IEmployeesService employeesService,
            IWorkOrdersService woService)
        {
            _clientService = clientService;
            _projectService = projectService;
            _employeeService = employeesService;
            _woService = woService;
        }

        public Task<IEnumerable<HomeBuilder>> GetHomeBuilderListAsync()
        {
            return Task.FromResult(GetFakeHomeBuilders());
        }
        public Task<HomeBuilder> GetHomeBuilderByIdAsync(int id)
        {
            return Task.FromResult(GetFakeHomeBuilders().First(s => s.Id.Equals(id)));
        }
        public async Task<List<Client>> GetClientsForBuilderAsync(int id)
        {
            var aBuilder = this.GetHomeBuilderByIdAsync(id);
            return await _clientService.GetClientsForHomeBuilderAsync(aBuilder.Id);
        }
        public async Task<List<Project>> GetProjectsForBuilderAsync(int id)
        {
            var aBuilder = this.GetHomeBuilderByIdAsync(id);
            return await _projectService.GetProjectsForHomeBuilderAsync(aBuilder.Id);
        }
        public async Task<List<Employee>> GetEmployeesForBuilderAsync(int id)
        {
            var aBuilder = this.GetHomeBuilderByIdAsync(id);
            return await _employeeService.GetEmployeesForHomeBuilderAsync(aBuilder.Id);
        }
        public Task<ServicePlan> GetServicePlansForBuilderAsync(int id)
        {
            return Task.FromResult(MakeFakeServicePlan(id));
        }
        public Task<Stats> GetStatsForBuilderAsync(int id)
        {
            var stats = new Stats()
            {
                AverageRating = _rnd.Next(3, 10),
                DaysSinceLastComplaint = _rnd.Next(50, 100),
                ActiveProjects = _rnd.Next(2, 9),
                CompletedProjects = _rnd.Next(40, 99),
                ProspectProjectCount = _rnd.Next(5, 20),
                CancelledProjects = _rnd.Next(10)
            };
            return Task.FromResult(stats);
        }
        public async Task<List<WorkOrder>> GetPendingWorkOrdersForBuilderAsync(int id)
        {
            var aBuilder = this.GetHomeBuilderByIdAsync(id);
            return await _woService.GetWorkOrdersForBuilderAsync(aBuilder.Id);
        }

        private IEnumerable<HomeBuilder> GetFakeHomeBuilders()
        {
            var builders = new List<HomeBuilder>();
            for (int i = 0; i < 5; i++)
            {
                builders.Add(MakeFakeHomeBuilder(i));
            }
            return builders;
        }
        private ServicePlan MakeFakeServicePlan(int id)
        {
            return new ServicePlan()
            {
                Type = PlanType.Basic,
                CreatedOn = DateTime.UtcNow,
                GracePeriodDays = (id * 4) + 5,
                MaxActiveProjectCount = 4,
                MaxEmployeeCount = 5,
                PlanStatus = PlanStatus.Running
            };
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