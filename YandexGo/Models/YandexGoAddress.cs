using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoAddress
    {
        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; } // Полное название с указанием города (Москва, Садовническая набережная, 82с2). Важно вводить населенный пункт с указанием номера дома, но без номера квартиры, подъезда, этажа

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("building")]
        public string Building { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        public YandexGoAddress(string latitude, string longitude, string fullname)
        {
            Coordinates = new double[] { Convert.ToDouble(longitude), Convert.ToDouble(latitude) };
            Fullname = fullname;
        }
    }
}