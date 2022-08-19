using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoSize
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        public YandexGoSize(double height, double length, double width)
        {
            Height = height != 0 ? height : 0.1;
            Length = length != 0 ? length : 0.1;
            Width = width != 0 ? width : 0.1;
        }
    }
}

