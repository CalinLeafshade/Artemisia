using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Types.Scenes
{
    [Serializable]
    public abstract class SceneObject
    {
        int x = 0;
        int y = 0;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        

        public SceneObject(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
