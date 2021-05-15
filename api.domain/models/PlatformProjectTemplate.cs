using System;
using System.Collections.Generic;

namespace api.domain.models
{
    /// <summary>
    /// A project template (i.e. example) provided by the HomeBuilder's platform
    /// </summary>
    public class PlatformProjectTemplate
    {
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public PlatformProjectTemplate()
        {
            Id = Guid.NewGuid();
            CreatdOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Title for the template
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        /// <summary>
        /// Description for the template
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
        /// <summary>
        /// Semantic Versioning (a.b.c) number for the template to distinguished from other similar versions
        /// </summary>
        /// <value></value>
        public string Version { get; set; }
        /// <summary>
        /// Date time stamp of when the template was revised
        /// </summary>
        /// <value></value>
        public DateTime LastRevision { get; set; }
        /// <summary>
        /// HomeBuilder's rating of how useful this template is
        /// </summary>
        /// <value></value>
        public decimal AverageRating { get; set; }
        /// <summary>
        /// Date time stamp when the template was created
        /// </summary>
        /// <value></value>
        public DateTime CreatdOn { get; private set; }
        /// <summary>
        /// A default collection of steps that are required to accomplis a project described by this template.
        /// </summary>
        /// <value></value>
        public List<PlatformStepTemplate> Steps { get; set; }
    }
}