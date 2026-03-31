using System.Collections.Generic;
using System.Windows.Documents;

namespace WpfGame
{
    public class Scene 
    {
        public string Id { get; set; }
        public string Background { get; set; }
        public string Text { get; set; }
        public List <Choice> Choices { get; set; }
       
    }
}
