using FeatureManager.Core.Protections;
using FeatureManager.Core.Providers;

namespace FeatureManager.Core.Appliers
{
    public class WhereApplier
    {
        private readonly IProvider<GeoLocation> _geolocationProvider;

        public WhereApplier(IProvider<GeoLocation> geolocationProvider)
        {
            _geolocationProvider = geolocationProvider;
        }

        private bool IsMatch(RestrictionWhere item, GeoLocation origin, GeoLocation destination)
        {
            return item.IsMatch(origin, destination);
        }

        public bool IsMatch(RestrictionWhere item, GeoLocation origin)
        {
            var destination = _geolocationProvider.Provide();
            return item.IsMatch(origin, destination);
        }

        public bool IsMatch(IEnumerable<RestrictionWhere> list, GeoLocation origin)
        {
            var destination = _geolocationProvider.Provide();
            foreach (var item in list)
            {
                if (IsMatch(item, origin, destination)) return true;
            }
            return false;
        }
    }
}
