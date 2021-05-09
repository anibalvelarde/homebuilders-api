using System;

namespace api.domain.models
{
    public class WorkOrderResponse
    {
        public WorkOrderResponse(WorkOrder action)
        {
            Id = Guid.NewGuid();
            StepRefId = action.StepReferenceId;
            RepliedOn = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public Guid StepRefId { get; private set; }
        public DateTime RepliedOn { get; private set; }
        public string Description { get; set; }
    }
}