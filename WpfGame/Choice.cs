using System.Text.Json.Serialization;

namespace WpfGame
{
    public class Choice
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("nextSceneId")]
        public string NextSceneId { get; set; }
    }
}
