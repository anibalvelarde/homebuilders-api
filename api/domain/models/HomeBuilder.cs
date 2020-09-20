using System.Collections.Generic;

namespace HomeBuilders.Api.Domain.Models
{
    public class HomeBuilder
    {
        /// <summary>
        /// Name of the company (e.g. LLC, LLP, Inc., etc)
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Address of the home builder's company
        /// </summary>
        /// <value></value>
        public string Address{ get; set; }
        /// <summary>
        /// Better Business Bureau Identifier
        /// </summary>
        /// <value></value>
        public string BbbId { get; set; }
        public string WebAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Project> Projects { get; set; }
    }
}