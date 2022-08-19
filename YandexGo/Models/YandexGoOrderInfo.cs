using Newtonsoft.Json;

namespace YandexGo
{
    public class OrderInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("eta")]
        public int ExpectedLeadTime { get; set; } //Ожидаемое время исполнения заказа в минутах

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_ts")]
        public DateTime CreatedTs { get; set; }

        [JsonProperty("updated_ts")]
        public DateTime UpdatedTs { get; set; }

        [JsonProperty("route_points")]
        public IReadOnlyCollection<YandexGoRoutePoint> RoutePoints { get; set; }

        [JsonProperty("items")]
        public IReadOnlyCollection<YandexGoCargoForShipment> Items { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("available_cancel_state")]
        public string AvailableCancelState { get; set; }
    }
}

