namespace api.domain.models.Enums
{
    /// <summary>
    /// Describes the HomeBuilder app client plan type
    /// </summary>
    public enum PlanType
    {
        /// $0 x month - 1 active project at a time | 3 customer max
        Freemium,
        /// $5 x month - up to 15 projects at a time | 10 customers max
        Basic,
        /// $29.95 x month - 100 projects at a time | 50 customers max
        Premium,
        /// Call to setup
        Enterprise
    }
}