using System;

namespace api.domain.models
{
    public class Project
    {
        public Project()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.MinValue;
        }
        public Project(Project proposal, Employee supervisor, Client owner)
        {
            Id = proposal.Id;
            CreatedOn = DateTime.UtcNow;
            Name = proposal.Name;
            TemplateReferenceId = proposal.TemplateReferenceId;
            Type = proposal.Type;
            Status = proposal.Status;
            FinancingBy = proposal.FinancingBy;
            SiteLocation = proposal.SiteLocation;
            Longitude = proposal.Longitude;
            Latitude = proposal.Latitude;
            Supervisor = supervisor;
            Owner = owner;
        }

        public Guid Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public string Name { get; set; }
        public Guid TemplateReferenceId { get; set; }
        public Enums.ProjectType Type { get; set; }
        public Enums.ProjectStatus Status { get; set; }
        public string FinancingBy { get; set; }
        public string SiteLocation { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Employee Supervisor { get; set; }
        public Client Owner { get; set; }
    }
}