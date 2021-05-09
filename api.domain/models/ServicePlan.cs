using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class ServicePlan
    {
        public Enums.PlanType Type { get; set;}
        public int GracePeriodDays { get; set;}
        public DateTime CreatedOn { get; set;}
        public Enums.PlanStatus PlanStatus { get; set;}
        public int MaxActiveProjectCount { get; set;}
        public int MaxEmployeeCount { get; set;}
    }
}