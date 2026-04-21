using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;

using System.Windows;
//using System.Drawing;
//using System.Windows.Forms;
namespace WpfGame
{
    public class StoryLoader 
    { 
        public static Dictionary<string,Scene> Load(string path)
        {
            try
            {
                string json = System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8);
                MessageBox.Show(json);
                var root = JsonSerializer.Deserialize<StoryRoot>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                var dict = new Dictionary<string, Scene>();
                foreach (var scene in root.Scenes)
                {
                    dict[scene.Id] = scene;
                }

                return dict;
            }
            catch (Exception  ex) 
            {
                MessageBox.Show(ex.Message);
                return null;

            }

        }

    }
}
//i am groot == я есть грут films