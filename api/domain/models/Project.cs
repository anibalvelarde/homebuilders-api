using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class Project
    {
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