using System;
using System.Collections.Generic;

namespace HomeBuilders.Api.Domain.Models
{
    public class RequestForAction
    {
        public RequestForAction(Guid stepRefId) 
        {
            Id = Guid.NewGuid();
            StepReferenceId = stepRefId;
            RequestedOn = DateTime.UtcNow;
        }

        public Guid Id {get; private set;}
        public Guid StepReferenceId {get; private set;}
        public DateTime RequestedOn {get; private set;}
        public string Description {get; set;}
        public List<string> Responses {get; set;}
    }
}