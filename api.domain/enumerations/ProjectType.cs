namespace api.domain.models.Enums
{
    /// <summary>
    /// A descriptor of the project type that can be created by a HomeBuilder
    /// </summary>
    public enum ProjectType
    {
        /// Residential family home (single/multi) construction
        Residential,
        /// Grocery or retail construction
        GroceryRetail,
        /// Restaurant construction
        Restaurant,
        /// Hotels/motels or other lodging facility construction
        Lodging,
        /// Business or office park construction
        Office,
        /// Industrial / warehousing construction
        Industrial,
        /// Medical facility (clinic, hospital, etc.) construction
        Medical,
        /// Athletic facility (arena, gym, etc.) construction
        Athletic,
        /// Any other construction not included by the other types
        Other
    }
}