using System;
using System.Collections.Generic;

namespace api.domain.models
{
    public class Client
    {
        public Client()
        {
            Id = Guid.Empty;
            CreatedOn = DateTime.MinValue;
        }

        public Client(Client prospect)
        {
            if (prospect.Id.Equals(Guid.Empty) &&
               prospect.CreatedOn.Equals(DateTime.MinValue))
            {
                Id = Guid.NewGuid();
                CreatedOn = DateTime.UtcNow;
                Name = prospect.Name;
                Address = prospect.Address;
                Email = prospect.Email;
                Phone = prospect.Phone;
                WebAddress = prospect.WebAddress;
            }
            else
            {
                throw new InvalidOperationException($"Client instance is not a prospect. ID: {prospect.Id}");
            }
        }

        /// <summary>
        /// Constructor to extract data from Graph DB (Neo4j)
        /// </summary>
        /// <param name="props">IReadOnlyDictionary of [string,string]</param>
        public Client(IReadOnlyDictionary<string, object> props)
        {
            props.TryGetValue("id", out object dbId);
            props.TryGetValue("createdOn", out object dbDate);
            props.TryGetValue("name", out object dbName);
            props.TryGetValue("address", out object dbAddress);
            props.TryGetValue("state", out object dbState);
            props.TryGetValue("email", out object dbEmail);
            props.TryGetValue("webAddress", out object dbWebAddress);

            Id = new Guid(Convert.ToString(dbId));
            CreatedOn = Convert.ToDateTime(dbDate);
            Name = Convert.ToString(dbName);
            Address = Convert.ToString(dbAddress);
            State = Convert.ToString(dbState);
            Email = Convert.ToString(dbEmail);
            Phone = "no-db-phone";
            WebAddress = Convert.ToString(dbWebAddress);
        }

        public static Client NewProspect(string name, string address, string email, string phone, string webAddress)
        {
            var p = new Client();
            p.Id = Guid.Empty;
            p.CreatedOn = DateTime.MinValue;
            p.Name = name;
            p.Address = address;
            p.Email = email;
            p.Phone = phone;
            p.WebAddress = webAddress;
            return p;
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public DateTime CreatedOn { get; private set; }
    }
}