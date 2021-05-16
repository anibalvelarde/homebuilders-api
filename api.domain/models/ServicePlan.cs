using System;

namespace api.domain.models
{
    /// <summary>
    /// Describes a service tier for the Home Builders platform
    /// </summary>
    public class ServicePlan
    {
        /// <summary>
        /// Identifier for the plan type
        /// </summary>
        /// <value></value>
        public Enums.PlanType Type { get; set; }
        /// <summary>
        /// The number of days the service will remain open while the plan owner is in "Past-Due" status
        /// </summary>
        /// <value></value>
        public int GracePeriodDays { get; set; }
        /// <summary>
        /// Date time stamp when the service/plan was created
        /// </summary>
        /// <value></value>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The current state of the Home Builders service plan
        /// </summary>
        /// <value></value>
        public Enums.PlanStatus PlanStatus { get; set; }
        /// <summary>
        /// Limit for the number of active projects that can exist under a service plan
        /// </summary>
        /// <value></value>
        public int MaxActiveProjectCount { get; set; }
        /// <summary>
        /// Limit for the number of employees that can be defined for a Home Builder
        /// </summary>
        /// <value></value>
        public int MaxEmployeeCount { get; set; }
    }
}