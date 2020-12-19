using System.Collections.Generic;

namespace HomeBuilders.Api.Domain.Models
{
    public class HomeBuilder
    {
        public HomeBuilder() { }
        public HomeBuilder(int id)
        {
            Id = id;
        }
        public HomeBuilder(int id, HomeBuilder template)
        {
            if (template.Id.Equals(0) && template.Employees is null && template.Projects is null)
            {
                this.Id = id;
                this.Name = template.Name;
                this.Address = template.Address;
                this.BbbId = template.BbbId;
                this.WebAddress = template.WebAddress;
                this.Phone = template.Phone;
                this.Email = template.Email;
            }
        }
        public int Id { get; private set; }
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
        /// Builder's projects registered in the platform
        /// </summary>
        /// <value></value>
        public List<Project> Projects { get; set; }
        /// <summary>
        /// Builder's employees
        /// </summary>
        /// <value></value>
        public List<Employee> Employees { get; set; }
    }
}