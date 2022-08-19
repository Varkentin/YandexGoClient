using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoRequirements
    {
        [JsonProperty("cargo_loaders")]
        public int CargoLoaders { get; set; }

        [JsonProperty("cargo_type")]
        public string CargoType { get; set; }

        [JsonProperty("pro_courier")]
        public bool ProCourier { get; set; }

        [JsonProperty("taxi_class")]
        public string TaxiClass { get; set; }
    }
}

