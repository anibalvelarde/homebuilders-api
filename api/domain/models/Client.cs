using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class Client 
    {
        public Client()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
        public Guid Id {get; private set;}
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set;}
        public string WebAddress {get; set;}
        public DateTime CreatedOn {get; private set;}
    }
}