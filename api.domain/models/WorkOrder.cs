using System;
using System.Collections.Generic;

namespace api.domain.models
{
    /// <summary>
    /// When a step or a project requires additional work to be performed, a Work Order identifies the nature of the work
    /// <Remarks>Work Orders can only be associated to a step of a project.</Remarks>
    /// </summary>
    public class WorkOrder
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stepRefId">The Step to which a work order is associated</param>
        public WorkOrder(Guid stepRefId)
        {
            Id = Guid.NewGuid();
            StepReferenceId = stepRefId;
            RequestedOn = DateTime.UtcNow;
        }
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Associated step identifier
        /// </summary>
        /// <value></value>
        public Guid StepReferenceId { get; private set; }
        /// <summary>
        /// Date time stamp when the work worder was created
        /// </summary>
        /// <value></value>
        public DateTime RequestedOn { get; private set; }
        /// <summary>
        /// Description of the work order
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
        /// <summary>
        /// A list of comments associated to the work order
        /// </summary>
        /// <value></value>
        public List<string> Responses { get; set; }
        /// <summary>
        /// Date time stamp on which a builder completed the work order
        /// </summary>
        /// <value></value>
        public DateTime? CompletedByBuilderOn { get; set; }
        /// <summary>
        /// Date time stamp on which the customer accepted the outcome of the work order
        /// </summary>
        /// <value></value>
        public DateTime? AcceptedByClientOn { get; set; }
    }
}