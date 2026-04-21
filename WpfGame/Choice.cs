using System.Text.Json.Serialization;

namespace WpfGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Choice
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("nextSceneId")]
        public string NextSceneId { get; set; }
    }
}
