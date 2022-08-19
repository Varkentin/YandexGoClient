using Newtonsoft.Json;

namespace YandexGo
{
    public class ErrorInfo
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

