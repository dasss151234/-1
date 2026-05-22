using System.Text.Json.Serialization;

namespace WpfGame
{
    public class MenuData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("background")]
        public string Background { get; set; }
    }
}

