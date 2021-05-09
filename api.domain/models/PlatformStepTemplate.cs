using System;

namespace api.domain.models
{
    public class PlatformStepTemplate
    {
        public PlatformStepTemplate()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; private set; }
    }
}