using System;
using System.Collections.Generic;

namespace api.domain.models
{
    public class PlatformProjectTemplate
    {
        public PlatformProjectTemplate()
        {
            Id = Guid.NewGuid();
            CreatdOn = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public DateTime LastRevision { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime CreatdOn { get; private set; }
        public List<PlatformStepTemplate> Steps { get; set; }
    }
}