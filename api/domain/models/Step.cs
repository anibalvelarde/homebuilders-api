using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class Step
    {
        public Guid StepReferenceId { get; set; }
        public Enums.StepStatus Status { get; set; }
        public int EstimatedDuration { get; set; }
        public Enums.TimeUnit DurationTimeUnit { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        public int DaysToComplete { get; set; }
        public DateTime ActualCompletionDate { get; set;}
    }
}