namespace FeatureManager.Core
{
    public class GeoLocation
    {
        public GeoLocation()
        {
        }

        public GeoLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString() => $"Lat: {Latitude} Lng: {Longitude}";
    }
}
