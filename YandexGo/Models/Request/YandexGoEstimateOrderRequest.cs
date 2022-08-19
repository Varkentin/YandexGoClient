using Newtonsoft.Json;

namespace YandexGo
{
    public class EstimateOrderRequest
    {
        [JsonProperty("items")]
        public List<YandexGoItem> Items { get; set; }

        [JsonProperty("route_points")]
        public List<YandexGoCoordinates> RoutePoints { get; set; }

        [JsonProperty("skip_door_to_door")]
        public bool SkipDoorToDoor { get; set; }

        [JsonProperty("requirements")]
        public YandexGoRequirements Requirements { get; set; }

        public EstimateOrderRequest(List<YandexGoItem> items, List<YandexGoCoordinates> routePoints)
        {
            Items = items;
            RoutePoints = routePoints;
        }
    }
}