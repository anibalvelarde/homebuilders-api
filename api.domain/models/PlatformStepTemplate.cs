using System;

namespace api.domain.models
{
    /// <summary>
    /// Description for a built-in project step that can be associated to a project
    /// </summary>
    public class PlatformStepTemplate
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PlatformStepTemplate()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Main label for a project-step template
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        /// <summary>
        /// Discription of a project-step template
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
        /// <summary>
        /// Date time stamp when the project-step template was created
        /// </summary>
        /// <value></value>
        public DateTime CreatedOn { get; private set; }
    }
}