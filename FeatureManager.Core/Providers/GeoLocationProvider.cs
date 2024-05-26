using Newtonsoft.Json.Linq;

namespace FeatureManager.Core.Providers
{
    public class GeoLocationProvider : IProvider<GeoLocation>
    {
        private static HttpClient _client = new HttpClient();
        private readonly System.Globalization.CultureInfo _cultureInfo = new System.Globalization.CultureInfo("en-US");

        public GeoLocation Provide()
        {
            var result = _client.GetAsync($"https://ipinfo.io?token=").GetAwaiter().GetResult();
            if (!result.IsSuccessStatusCode) return null!;
            var jObject = JObject.Parse(result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            var parts = jObject["loc"]!.ToString().Split(',');
            var latitude = double.Parse(parts[0], _cultureInfo);
            var longitude = double.Parse(parts[1], _cultureInfo);
            return new GeoLocation(latitude, longitude);
        }
    }
}
