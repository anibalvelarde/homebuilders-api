namespace api.domain
{
    /// <summary>
    /// Determines the LAT/LON coordinates
    /// </summary>
    public class GeoLocation
    {
        /// <summary>
        /// Longitude (East-West) coordinate in double precision format
        /// </summary>
        /// <value></value>
        public double Longitude { get; set; }
        /// <summary>
        /// Latitude (North-South) coordinate in double precision format
        /// </summary>
        /// <value></value>
        public double Latitude { get; set; }
    }
}