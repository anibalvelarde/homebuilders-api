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
        public Task<IEnumerable<HomeBuilder>> GetHomeBuilderList()
        {
            return Task.FromResult(GetFakeHomeBuilders());
        }
        public Task<HomeBuilder> GetHomeBuilderById(int id)
        {
            return Task.FromResult(GetFakeHomeBuilders().First(s => s.Id.Equals(id)));
        }
        public Task<List<Client>> GetClientsForBuilder(int id)
        {
            var aBuilder = this.GetHomeBuilderById(id);
            var clients = new List<Client>();
            for (int i = 0; i < 5; i++)
            {
                clients.Add(MakeFakeClient(i));
            }
            return Task.FromResult(clients);
        }

        public Task<List<Project>> GetProjectsForBuilder(int id)
        {
            var aBuilder = this.GetHomeBuilderById(id);
            var projects = new List<Project>();
            for (int i = 0; i < 5; i++)
            {
                projects.Add(MakeFakeProject(i));
            }
            return Task.FromResult(projects);
        }

        public Task<List<Employee>> GetEmployeesForBuilder(int id)
        {
            var aBuilder = this.GetHomeBuilderById(id);
            var employees = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                employees.Add(MakeFakeEmployee(i));
            }
            return Task.FromResult(employees);
        }

        public Task<ServicePlan> GetServicePlansForBuilder(int id)
        {
            return Task.FromResult(MakeFakeServicePlan(id));
        }

        public Task<Stats> GetStatsForBuilder(int id)
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

        public Task<List<WorkOrder>> GetPendingWorkOrdersForBuilder(int id)
        {
            var aBuilder = this.GetHomeBuilderById(id);
            var workOrders = new List<WorkOrder>();
            for (int i = 0; i < 5; i++)
            {
                workOrders.Add(MakeFakeWorkOrder(i));
            }
            return Task.FromResult(workOrders);
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
        private WorkOrder MakeFakeWorkOrder(int id)
        {
            return new WorkOrder(Guid.NewGuid())
            {
                Description = $"Please, work on this issue {id}"
            };
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
        private Employee MakeFakeEmployee(int id)
        {
            return new Employee()
            {
                Id = Guid.NewGuid(),
                Name = $"Fake-EE-Name-{id}",
                Role = EmployeeRole.AdminStaff
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
        private Project MakeFakeProject(int id)
        {
            return new Project()
            {
                TemplateReferenceId = Guid.NewGuid(),
                Type = ProjectType.Lodging,
                Status = ProjectStatus.Organizing,
                FinancingBy = $"Wings Financial (ID:{id})",
                Owner = MakeFakeClient(id + 3)
            };
        }
        private Client MakeFakeClient(int fakeBuilderId)
        {
            return new Client()
            {
                Name = $"Fake name {fakeBuilderId}",
                Address = $"Fake address for ID: {fakeBuilderId}",
                Email = $"email-{fakeBuilderId}@server-{fakeBuilderId}.com",
                Phone = $"867-5{fakeBuilderId}-5309",
                WebAddress = $"www.server-{fakeBuilderId}.com"
            };
        }
    }
}