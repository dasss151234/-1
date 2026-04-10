using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace WpfGame
{
    public class StoryLoader 
    { 
        public static Dictionary<string,Scene> Load(string path)
        {
            string json = File.ReadAllText(path);
            var root = JsonSerializer.Deserialize<StoryRoot>(json);
            var dict = new Dictionary<string,Scene>();
            foreach (var scene in root.Scenes) 
            {
                dict[scene.id] = scene;
            }

        }
    }
}
//i am groot == я есть грут films