using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoItem
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("size")]
        public YandexGoSize Size { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        public YandexGoItem(int quantity)
        {
            Quantity = quantity;
        }
    }
}

