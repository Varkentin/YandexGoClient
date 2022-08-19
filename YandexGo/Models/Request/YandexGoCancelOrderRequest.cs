using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoCancelOrderRequest
    {
        [JsonProperty("cancel_state")]
        public string CancelState { get; set; }// free, paid

        [JsonProperty("version")]
        public string Version { get; set; }

        public YandexGoCancelOrderRequest(string cancelState, string version)
        {
            CancelState = cancelState;
            Version = version;
        }
    }
}

