using Microsoft.Extensions.DependencyInjection;
using api.business.interfaces;
using api.business.services;

namespace api.business.extensions
{
    public static class BusinessSerivceExensions
    {
        public static void SetupBusinessDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHomeBuildersService, HomeBuildersService>();
            services.AddScoped<IClientsService, ClientsService>();
            services.AddScoped<IProjectsService, ProjectsService>();
            services.AddScoped<IWorkOrdersService, WorkOrdersService>();
            services.AddScoped<IEmployeesService, EmployeesService>();
            services.AddScoped<IServicePlansService, ServicePlansService>();

        }
    }
}