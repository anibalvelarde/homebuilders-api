using System;

namespace api.domain.models
{
    /// <summary>
    /// Describes a building effort that a Home Builder will add to their work-log
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Parameterless constructor
        /// <Remarks>The project identifier and the created-on date are added by default.</Remarks>
        /// </summary>
        public Project()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.MinValue;
        }

        /// <summary>
        /// Create a new instance of a project
        /// </summary>
        /// <param name="proposal">A project proposal (i.e. A project that has not been initialized)</param>
        /// <param name="supervisor">The supervisor assigned to this project.</param>
        /// <param name="owner">The client to whom the project will be delivered.</param>
        /// <Remarks>The project identifier and the created-on date are added by default.</Remarks>
        /// <Remarks>The project is initialized with status "Created"</Remarks>
        public Project(Project proposal, Employee supervisor, Client owner)
        {
            Id = proposal.Id;
            CreatedOn = DateTime.UtcNow;
            Name = proposal.Name;
            TemplateReferenceId = proposal.TemplateReferenceId;
            Type = proposal.Type;
            Status = Enums.ProjectStatus.Created;
            FinancingBy = proposal.FinancingBy;
            SiteLocation = proposal.SiteLocation;
            Location = proposal.Location;
            Supervisor = supervisor;
            Owner = owner;
        }

        /// <summary>
        /// Unique identifier for a Project
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Date on which the project was registered in the system
        /// </summary>
        /// <value></value>
        public DateTime CreatedOn { get; private set; }
        /// <summary>
        /// A human readable name for the project that can be used to recognize the porject in a list
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// If the project was created from a template, it identifies the template that was used as base line
        /// </summary>
        /// <value></value>
        public Guid TemplateReferenceId { get; set; }
        /// <summary>
        /// Identifies the category for the project
        /// </summary>
        /// <value></value>
        public Enums.ProjectType Type { get; set; }
        /// <summary>
        /// Identifies the project status
        /// </summary>
        /// <value></value>
        public Enums.ProjectStatus Status { get; set; }
        /// <summary>
        /// When populated, determines the finanical institution that will be financing the project
        /// </summary>
        /// <value></value>
        public string FinancingBy { get; set; }
        /// <summary>
        /// Address for the project
        /// </summary>
        /// <value></value>
        public string SiteLocation { get; set; }
        GeoLocation Location { get; set; }
        /// <summary>
        /// Supervisor (HomeBuilder's employee) for the project
        /// </summary>
        /// <value></value>
        public Employee Supervisor { get; set; }
        /// <summary>
        /// The party for whom the project is being built
        /// </summary>
        /// <value></value>
        public Client Owner { get; set; }
    }
}