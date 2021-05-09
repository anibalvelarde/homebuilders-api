namespace api.domain.models.Enums
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