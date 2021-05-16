using System;

namespace api.domain.models
{
    /// <summary>
    /// Represents a comment that is made by a user of the platform (i.e. Home Builder Employee or Home Builder Customer)
    /// </summary>
    public class Commentary
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public Commentary() { }

        /// <summary>
        /// Determines if the comment provided was positive or negative
        /// </summary>
        /// <value></value>
        public Enums.CommentType Type { get; set; }
        /// <summary>
        /// Date time stamp of when the comment was created
        /// </summary>
        /// <value></value>
        public DateTime CommentedOn { get; set; }
        /// <summary>
        /// Text containing the comment provided
        /// </summary>
        /// <value></value>
        public string Text { get; set; }
        /// <summary>
        /// Rating provided at the time of comment creation
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
    }
}