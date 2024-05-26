using FeatureManager.Core.Interfaces;

namespace FeatureManager.Core
{
    public class RestrictionWhere : BaseRestriction
    {
        public IDistanceTarget DistanceTarget { get; }

        public RestrictionWhere(IDistanceTarget distanceTarget)
        {
            DistanceTarget = distanceTarget;
        }

        public RestrictionWhere(IDistanceTarget distanceTarget, string name) : base(name)
        {
            DistanceTarget = distanceTarget;
        }

        public RestrictionWhere(IDistanceTarget distanceTarget, string name, string description) : base(name, description)
        {
            DistanceTarget = distanceTarget;
        }

        public bool IsMatch(GeoLocation origin, GeoLocation destination)
        {
            var distanceInMeters = Geolocation.GeoCalculator.GetDistance(origin.Latitude, origin.Longitude, destination.Latitude, destination.Longitude, distanceUnit: Geolocation.DistanceUnit.Meters);
            return DistanceTarget.IsMatch(distanceInMeters);
        }
    }
}
