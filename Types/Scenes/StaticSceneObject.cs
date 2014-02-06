using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Types.Scenes
{
    [Serializable]
    public class StaticSceneObject : SceneObject
    {
        public StaticSceneObject(int x, int y)
            : base(x, y)
        {

        }
    }
}
