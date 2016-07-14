using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace MonoGame.Extended.Gui.Wip
{
    public class GuiDefinition
    {
        public string TextureAtlas { get; set; }
        public string[] Fonts { get; set; }
        public Dictionary<string, JObject> Styles { get; set; }
    }
}