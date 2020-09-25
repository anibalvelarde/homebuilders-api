using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class RfaResponse
    {
        public RfaResponse(RequestForAction rfa)
        {
            Id = Guid.NewGuid();
            StepRefId = rfa.StepReferenceId;
            RepliedOn = DateTime.UtcNow;
        }

        public Guid Id {get; private set;}
        public Guid StepRefId {get; private set;}
        public DateTime RepliedOn {get; private set;}
        public string Description {get; set;}
    }
}