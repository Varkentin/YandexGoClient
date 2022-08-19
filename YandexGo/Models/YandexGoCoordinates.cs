using System.Globalization;
using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoCoordinates
    {
        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }

        public YandexGoCoordinates(double latitude, double longitude)
        {
            Coordinates = new double[] { longitude, latitude};
        }

        public YandexGoCoordinates(string latitude, string longitude)
        {
            if (!double.TryParse(latitude, NumberStyles.Any, CultureInfo.InvariantCulture, out var lat))
                lat = 0;
            if (!double.TryParse(longitude, NumberStyles.Any, CultureInfo.InvariantCulture, out var lng))
                lng = 0;
            Coordinates = new double[] { lng, lat};
        }
    }
}

