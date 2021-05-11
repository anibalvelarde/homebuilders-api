
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

        public async Task<Client> FetchClientByIdAsync(Guid id)
        {
            Client result = null;
            var statementTemplate = $"MATCH(c:Client) WHERE c.id = '{id}'  RETURN c;";
            using (_dbDriver)
            {
                var session = _dbDriver.AsyncSession();
                var statementResult = await session.RunAsync(statementTemplate);
                var recordCount = 0;
                var resultSummary = await statementResult.ForEachAsync((ir) =>
                {
                    var props = ir["c"].As<INode>().Properties;
                    result = new Client(props);
                    recordCount++;
                });

                if (recordCount > 1)
                {
                    throw new Exception($"Multiple records found with same ID:{id}");
                }
            }
            return result;
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

        public async Task<IEnumerable<Client>> SearchClientsByNameAsync(string namePattern)
        {
            var result = new List<Client>();
            var statementTemplate = $"MATCH(c:Client) WHERE c.name =~ '.*{namePattern}.*' RETURN c;";
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

        public async Task<Client> AddClient(Client prospect)
        {
            var newClient = new Client(prospect);
            var statementTemplate = $@"CREATE(c:Client {{
                id: '{newClient.Id}',
                createdOn: '{newClient.CreatedOn}',
                name: '{newClient.Name}',
                address: '{newClient.Address}',
                email: '{newClient.Email}',
                phone: '{newClient.Phone}',
                webAddress: '{newClient.WebAddress}'}})
                RETURN c;";

            using (_dbDriver)
            {
                var session = _dbDriver.AsyncSession();
                var statementResult = await session.RunAsync(statementTemplate.Replace("\"", "'"));
            }
            return newClient;
        }

        public async Task<Client> DeleteClientByIdAsync(Guid id)
        {
            Client result = null;
            var fetchStatementTemplate = $"MATCH(c:Client) WHERE c.id = '{id}'  RETURN c;";
            using (_dbDriver)
            {
                var fetchSession = _dbDriver.AsyncSession();
                var fetchStatementResult = await fetchSession.RunAsync(fetchStatementTemplate);
                var recordCount = 0;
                var resultSummary = await fetchStatementResult.ForEachAsync((ir) =>
                {
                    var props = ir["c"].As<INode>().Properties;
                    result = new Client(props);
                    recordCount++;
                });
                if (recordCount > 1)
                {
                    throw new Exception($"Multiple records found with same ID:{id}");
                }
                var deleteSession = _dbDriver.AsyncSession();
                var deleteStatementTemplate = $"MATCH(c:Client {{id: '{id}'}}) DELETE c;";
                var deleteStatementResult = await deleteSession.RunAsync(deleteStatementTemplate);
            }
            return result;
        }

        public async Task<Client> UpdateExistingClient(Guid id, Client clientToUpdate)
        {
            Client result = null; Client currentClient = null;
            var fetchStatementTemplate = $"MATCH(c:Client) WHERE c.id = '{id}'  RETURN c;";
            using (_dbDriver)
            {
                var fetchSession = _dbDriver.AsyncSession();
                var fetchStatementResult = await fetchSession.RunAsync(fetchStatementTemplate);
                var recordCount = 0;
                var resultSummary = await fetchStatementResult.ForEachAsync((ir) =>
                {
                    var props = ir["c"].As<INode>().Properties;
                    currentClient = new Client(props);
                    recordCount++;
                });
                if (recordCount > 1)
                {
                    throw new Exception($"Multiple records found with same ID:{clientToUpdate.Id}");
                }
                var updateSession = _dbDriver.AsyncSession();
                var updateStatementTemplate = $@"MATCH(c:Client {{id: '{id}'}})
                    SET
                      c.name = '{clientToUpdate.Name}',
                      c.address = '{clientToUpdate.Address}',
                      c.email = '{clientToUpdate.Email}',
                      c.phone = '{clientToUpdate.Phone}',
                      c.webAddress = '{clientToUpdate.WebAddress}'
                    ;";
                var updateStatementResult = await updateSession.RunAsync(updateStatementTemplate);
                result = currentClient.Update(clientToUpdate);
            }
            return result;
        }
    }

    static class Utilities
    {
        /// <summary>
        /// Updating attributes of a Client
        /// </summary>
        /// <param name="existingclient"></param>
        /// <param name="updateWithThis"></param>
        /// <returns></returns>
        public static Client Update(this Client existingclient, Client updateWithThis)
        {
            if (updateWithThis.Id.Equals(Guid.Empty) && !existingclient.Id.Equals(Guid.Empty))
            {
                existingclient.Name = updateWithThis.Name;
                existingclient.Address = updateWithThis.Address;
                existingclient.Email = updateWithThis.Email;
                existingclient.Phone = updateWithThis.Phone;
                existingclient.WebAddress = updateWithThis.WebAddress;
                return existingclient;
            }
            throw new InvalidOperationException("Operation not allowed.");
        }

    }
}