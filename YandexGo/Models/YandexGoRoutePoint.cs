using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoRoutePoint
    {
        [JsonProperty("point_id")]
        public int PointId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visit_order")]
        public int VisitOrder { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contact")]
        public YandexGoContact Contact { get; set; }

        [JsonProperty("address")]
        public YandexGoAddress Address { get; set; }

        public YandexGoRoutePoint(YandexGoAddress address, YandexGoContact contact, int pointId, string type, int visitOrder)
        {
            Address = address;
            Contact = contact;
            PointId = pointId;
            Type = type;
            VisitOrder = visitOrder;
        }
    }
}

