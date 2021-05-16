using api.data.interfaces;
using api.data.serivices;
using Microsoft.Extensions.DependencyInjection;
using Neo4j.Driver;

namespace api.data.extensions
{
    public static class DataExtensions
    {
        public static void SetupDataDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDriver>((s) =>
            {
                var usrName = "neo4j";
                var pswd = "test";
                var bolt = $"{usrName}://localhost:7687";
                var authToken = AuthTokens.Basic(usrName, pswd);

                return GraphDatabase.Driver(bolt, authToken);
            });
            services.AddScoped<IClientDataProvider, ClientDataProvider>();
        }
    }
}