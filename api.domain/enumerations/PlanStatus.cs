namespace HomeBuilders.Api.Domain.Models.Enums
{
    public enum PlanStatus
    {
        Created,
        PendingIdVerification,
        Running,
        CancelledByUser,
        CancelledByPlatform,
        Delinquent
    }
}