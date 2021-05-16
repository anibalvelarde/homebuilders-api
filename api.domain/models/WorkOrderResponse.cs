using System;

namespace api.domain.models
{
    /// <summary>
    /// Catalogs a response to a WorkOrder
    /// </summary>
    public class WorkOrderResponse
    {
        /// <summary>
        /// Ctor for WorkOrderResponse
        /// </summary>
        /// <param name="action">A WorkOrder for which to build a response</param>
        public WorkOrderResponse(WorkOrder action)
        {
            Id = Guid.NewGuid();
            StepRefId = action.StepReferenceId;
            RepliedOn = DateTime.UtcNow;
        }
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Identifier for the step to which this response is addressing
        /// </summary>
        /// <value></value>
        public Guid StepRefId { get; private set; }
        /// <summary>
        /// Date when this WorkOrderResponse was created
        /// </summary>
        /// <value></value>
        public DateTime RepliedOn { get; private set; }
        /// <summary>
        /// Description of the response of the work order
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
    }
}