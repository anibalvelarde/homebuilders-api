namespace api.domain.models.Enums
{
    /// <summary>
    /// Determines the role of an Employee of HomeBuilder's client
    /// </summary>
    public enum EmployeeRole
    {
        /// Owner of the building company
        CompanyOwner,
        /// Admin staff of the building company
        AdminStaff,
        /// Engineer
        Engineer,
        /// Construction site supervisor/foreman
        Supervisor,
        /// Sales personnel
        Sales,
        /// Construction project contractor
        Contractor,
        /// Uncategorized employee
        Other
    }
}