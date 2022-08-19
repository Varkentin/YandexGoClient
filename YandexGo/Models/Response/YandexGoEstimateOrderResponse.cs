using Newtonsoft.Json;

namespace YandexGo
{
    public class EstimateOrderResponse
    {
        [JsonProperty("currency_rules")]
        public YandexGoCurrencyRules CurrencyRules { get; set; }

        [JsonProperty("requirements")]
        public YandexGoRequirements Requirements { get; set; }

        [JsonProperty("distance_meters")]
        public string DistanceMeters { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("zone_id")]
        public string ZoneId { get; set; }
    }
}