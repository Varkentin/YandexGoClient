using Newtonsoft.Json;

namespace YandexGo
{
    public class CancelOrderResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user_request_revision")]
        public string UserRequestRevision { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}