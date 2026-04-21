using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace WpfGame
{
    public class StoryRoot
    {
        [JsonPropertyName("scenes")]
        public List<Scene> Scenes { get; set; }
    }
}
