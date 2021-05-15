namespace api.domain.models
{
    /// <summary>
    /// Aggregates the ratings | score | statistics for a given Home Builder
    /// <Remarks>These figures are related to the point in time when the Home Builder was registerd to this platform</Remarks>
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Average customer rating
        /// </summary>
        /// <value></value>
        public decimal AverageRating { get; set; }
        /// <summary>
        /// Number of days since the last complaint
        /// </summary>
        /// <value></value>
        public int DaysSinceLastComplaint { get; set; }
        /// <summary>
        /// Number of active projects for the Home Builder
        /// </summary>
        /// <value></value>
        public int ActiveProjects { get; set; }
        /// <summary>
        /// Number of projects that Home Builder has completed
        /// </summary>
        /// <value></value>
        public int CompletedProjects { get; set; }
        /// <summary>
        /// Number of projective projects the Home Builder has on-hand at this time
        /// </summary>
        /// <value></value>
        public int ProspectProjectCount { get; set; }
        /// <summary>
        /// Number of the projects that Home Builder has had to cancel since start
        /// </summary>
        /// <value></value>
        public int CancelledProjects { get; set; }
    }
}