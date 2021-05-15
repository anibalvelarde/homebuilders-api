using System;

namespace api.domain.models
{
    /// <summary>
    /// A distict and seprate stage for completing a project
    /// </summary>
    public class Step
    {
        /// <summary>
        /// Unique identifier for a step
        /// </summary>
        /// <value></value>
        public Guid StepReferenceId { get; set; }
        /// <summary>
        /// Determines the state of a step within a project
        /// </summary>
        /// <value></value>
        public Enums.StepStatus Status { get; set; }
        /// <summary>
        /// Estimated time duration value of how many TimeUnits will the project take to be completed
        /// </summary>
        /// <value></value>
        public int EstimatedDuration { get; set; }
        /// <summary>
        /// Time unit for the project (Year, Months, days, etc.)
        /// </summary>
        /// <value></value>
        public Enums.TimeUnit DurationTimeUnit { get; set; }
        /// <summary>
        /// Esimated date for completion of the project
        /// </summary>
        /// <value></value>
        public DateTime EstimatedCompletionDate { get; set; }
        /// <summary>
        /// When an actual completion date is set, this indicates the number of days the step took to complete
        /// </summary>
        /// <value></value>
        public int DaysToComplete { get; set; }
        /// <summary>
        /// Date time stamp when the step was actually completed
        /// </summary>
        /// <value></value>
        public DateTime ActualCompletionDate { get; set; }
    }
}