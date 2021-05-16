namespace api.domain.models.Enums
{
    /// <summary>
    /// Kind of comment that can be provided by a user of the platform (homebuilder or homebuilder's customer)
    /// </summary>
    public enum CommentType
    {
        /// A positive comment provided by a user
        Praise,
        /// A negative comment provided by a user
        Complaint
    }
}