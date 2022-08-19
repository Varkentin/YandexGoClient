using Newtonsoft.Json;

namespace YandexGo
{
    public class AvailableTariff
    {
        [JsonProperty("minimal_price")]
        public string MinimalPrice { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}