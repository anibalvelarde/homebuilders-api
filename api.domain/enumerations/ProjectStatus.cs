namespace api.domain.models.Enums
{
    /// <summary>
    /// Determines the state of a HomeBuilder's project
    /// </summary>
    public enum ProjectStatus
    {
        /// Initial state for a project
        Organizing,
        /// Actively working with a customer on the conceptual view of a project
        PlanningDesign,
        /// Selecting the team that will be executing the project
        TeamAssignment,
        /// Deploying equipment, labor and materials to project site
        Mobilization,
        /// Actively working on the project site
        Operations,
        /// Initiation of closing activities for a project
        Closing,
        /// Project was abandoned. This could happen at any stage.
        Abandoned
    }
}