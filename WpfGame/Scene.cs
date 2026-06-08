using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows.Documents;

namespace WpfGame
{
    public class Scene 
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("background")]
        public string Background { get; set; }
        [JsonPropertyName("isEnding")]
        public bool IsEnding { get; set; }
        [JsonPropertyName("characterImage")]
        public string characterImage { get; set; }
        [JsonPropertyName("characterPosition")]
        public string CharacterPosition {  get; set; }
        [JsonPropertyName("choices")]
        public List <Choice> Choices { get; set; }
       
    }
}
