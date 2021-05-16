namespace api.domain.models.Enums
{
    /// <summary>
    /// Describes the state of a HomeBuilder's API user
    /// </summary>
    public enum PlanStatus
    {
        /// New plan was created
        Created,
        /// Pending verification of HomeBuilder opening a plan
        PendingIdVerification,
        /// HomeBuilder's plan is operational
        Running,
        /// HomeBuilder's plan was cancelled by the client
        CancelledByUser,
        /// HomeBuilder's plan was cancelled by HB platform
        CancelledByPlatform,
        /// HomeBuilder's plan balance is past due
        Delinquent
    }
}