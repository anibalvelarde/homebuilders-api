using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class Client
    {
        public Client()
        {
            SetupNew();
        }

        public Client(Client prospect)
        {
            if (prospect.Id.Equals(Guid.Empty) &&
               prospect.CreatedOn.Equals(DateTime.MinValue)
               )
            {
                SetupNew();
                Name = prospect.Name;
                Address = prospect.Address;
                Email = prospect.Email;
                Phone = prospect.Phone;
                WebAddress = prospect.WebAddress;
            }
            throw new InvalidOperationException($"Client instance is not a prospect. ID: {prospect.Id}");
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
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public DateTime CreatedOn { get; private set; }

        private void SetupNew()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
    }
}