using System;
using System.Collections.Generic;

namespace HomeBuilders.Api.Domain.Models
{
    public class Registration
    {
        public Registration() { }

        public static Registration RegisterProspect(Registration prospect)
        {
            if (Guid.Empty.Equals(prospect.Id))
            {
                return new Registration()
                {
                    Id = Guid.NewGuid(),
                    Name = prospect.Name,
                    Address = prospect.Address,
                    BbbId = prospect.BbbId,
                    WebAddress = prospect.WebAddress,
                    Phone = prospect.Phone,
                    Email = prospect.Email,
                    Owner = prospect.Owner
                };
            }
            throw new ArgumentException("Cannot register an initialized prospect.");
        }

        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the company (e.g. LLC, LLP, Inc., etc)
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// Address of the home builder's company
        /// </summary>
        /// <value></value>
        public string Address { get; set; }

        /// <summary>
        /// Better Business Bureau Identifier
        /// </summary>
        /// <value></value>
        public string BbbId { get; set; }

        /// <summary>
        /// URL for Builder's website (if any)
        /// </summary>
        /// <value></value>
        public string WebAddress { get; set; }

        /// <summary>
        /// Business phone number
        /// </summary>
        /// <value></value>
        public string Phone { get; set; }

        /// <summary>
        /// Business email number
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        /// <summary>
        /// Builder's owner info
        /// </summary>
        /// <value></value>
        public Employee Owner { get; set; }
    }
}