using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoCurrencyRules
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

