using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoCargoForShipment
    {
        [JsonProperty("cost_currency")]
        public string CostCurrency { get; set; }

        [JsonProperty("cost_value")]
        public string CostValue { get; set; }

        [JsonProperty("droppof_point")]
        public int DroppofPoint { get; set; }

        [JsonProperty("pickup_point")]
        public int PickupPoint { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; } //Вес единицы товара в кг

        [JsonProperty("size")]
        public YandexGoSize Size { get; set; }


        public YandexGoCargoForShipment(string costCurrency, string costValue, double weight, int quantity, string title, YandexGoSize size)
        {
            CostCurrency = costCurrency;
            CostValue = costValue;
            PickupPoint = 1;
            DroppofPoint = 2;
            Quantity = quantity;
            Weight = weight != 0 ? weight : 0.1;
            Title = title;
            Size = size;
        }
    }
}