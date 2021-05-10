
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;
using Neo4j.Driver;

namespace api.data.serivices
{
    internal class ClientDataProvider : interfaces.IClientDataProvider
    {
        private readonly IDriver _dbDriver;

        public ClientDataProvider(IDriver dbConnection)
        {
            _dbDriver = dbConnection;
        }
        public async Task<List<Client>> FetchAllClientsAsync()
        {
            var result = new List<Client>();
            var statementTemplate = "MATCH(c:Client) RETURN c;";
            using (_dbDriver)
            {
                var session = _dbDriver.AsyncSession();
                var statementResult = await session.RunAsync(statementTemplate);
                var resultSummary = await statementResult.ForEachAsync((ir) =>
                {
                    var props = ir["c"].As<INode>().Properties;
                    result.Add(new Client(props));
                });
            }
            return result;
        }
    }
}