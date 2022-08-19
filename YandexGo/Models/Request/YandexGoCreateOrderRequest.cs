using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace YandexGo
{
    public class CreateOrderRequest
    {
        [JsonProperty("items")]
        public List<YandexGoCargoForShipment> Items { get; set; }

        [JsonProperty("route_points")]
        public List<YandexGoRoutePoint> RoutePoints { get; set; }

        [JsonProperty("due")]
        public DateTime Due { get; set; } // Создать заказ к определенному времени

        [JsonProperty("requirements")]
        public YandexGoRequirements Requirements { get; set; }

        public CreateOrderRequest(List<YandexGoCargoForShipment> items, List<YandexGoRoutePoint> routePoints, DateTime due)
        {
            Due = due;
            Items = items;
            RoutePoints = routePoints;
        }
    }
}