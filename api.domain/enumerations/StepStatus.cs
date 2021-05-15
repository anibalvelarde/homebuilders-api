namespace api.domain.models.Enums
{
    /// <summary>
    /// Refers to the status of an HB task
    /// </summary>
    public enum StepStatus
    {
        /// A task has begun
        Started,
        /// A task was cancelled by HomeBuilder's customer
        CancelledByCustomer,
        /// A task was cancelled by HomeBuilder
        Cancelled,
        /// A task was completed by HomeBuilder
        Completed
    }
}