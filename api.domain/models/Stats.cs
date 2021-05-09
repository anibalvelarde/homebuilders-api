namespace api.domain.models
{
    public class Stats
    {
        public decimal AverageRating { get; set; }
        public int DaysSinceLastComplaint { get; set; }
        public int ActiveProjects { get; set; }
        public int CompletedProjects { get; set; }
        public int ProspectProjectCount { get; set; }
        public int CancelledProjects { get; set; }
    }
}