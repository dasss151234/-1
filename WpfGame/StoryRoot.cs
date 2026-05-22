using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace WpfGame
{
    public class StoryRoot
    {
        [JsonPropertyName("menu")]
        public MenuData Menu { get; set; }
        [JsonPropertyName("scenes")]
        public List<Scene> Scenes { get; set; }
    }
}
