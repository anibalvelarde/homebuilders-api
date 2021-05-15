namespace api.domain.models.Enums
{
    /// <summary>
    /// Unit of time relevant for HB operations
    /// </summary>
    public enum TimeUnit
    {
        /// 1/365th of a year
        Day,
        /// 1/52nd of ayear
        Week,
        /// 1/12th of a year
        Month,
        /// 3 months
        Quarter,
        /// 1 Earthly calendar year
        Year
    }
}