using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Types.Scenes
{

    public enum MaskType { Walkable, Hotspot, Region };

    [Serializable]
    public class Scene
    {
        string name = "";
        List<SceneObject> objects;
        Dictionary<MaskType, SceneMask> masks;

        public List<SceneObject> Objects
        {
            get { return objects; }
            set { objects = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Scene()
        {
            objects = new List<SceneObject>();
        }
      
    }
}
