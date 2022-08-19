using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoOrdersInfo
    {
        [JsonProperty("claims")]
        public IReadOnlyCollection<OrderInfo> Claims { get; }
    }
}