using Newtonsoft.Json;

namespace YandexGo
{
    public class YandexGoContact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        public YandexGoContact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public YandexGoContact()
        {
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
        }
    }
}