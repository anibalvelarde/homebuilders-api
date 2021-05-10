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

            if (Guid.TryParse(Convert.ToString(dbId), out Guid tempGuid))
            {
                Id = tempGuid;
            }
            else
            {
                Id = Guid.Empty;
            }
            CreatedOn = Convert.ToDateTime(dbDate);
            Name = Convert.ToString(dbName);
            Address = Convert.ToString(dbAddress);
            State = Convert.ToString(dbState);
            Email = Convert.ToString(dbEmail);
            Phone = "no-db-phone";
            WebAddress = Convert.ToString(dbWebAddress);
        }

        /// <summary>
        /// Instantiating a Prospect. No ID (Guid) is generated for a prospect.
        /// </summary>
        /// <param name="name">the Name of the prospect</param>
        /// <param name="address">the street Address for the prospect</param>
        /// <param name="email">the Email for the prospect</param>
        /// <param name="phone">the Phone for the prospect</param>
        /// <param name="webAddress">the URL for prospect</param>
        /// <returns></returns>
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

        /// <summary>
        /// Unique identifier (Guid)
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Name of the business
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Address where business is located
        /// </summary>
        /// <value></value>
        public string Address { get; set; }
        /// <summary>
        /// State where the business HQ are located
        /// </summary>
        /// <value></value>
        public string State { get; set; }
        /// <summary>
        /// Preferred Email address to receive general email communications
        /// </summary>
        /// <value></value>
        public string Email { get; set; }
        /// <summary>
        /// Main Phone number for the business
        /// </summary>
        /// <value></value>
        public string Phone { get; set; }
        /// <summary>
        /// URL for the business. Write "none" if no website is available.
        /// </summary>
        /// <value></value>
        public string WebAddress { get; set; }
        /// <summary>
        /// Date when the HomeBuilders record was created
        /// </summary>
        /// <value></value>
        public DateTime CreatedOn { get; private set; }
    }
}