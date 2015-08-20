using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocosSharp;

namespace BasicUI_CocosSharp
{
    public class TestLayer : CCLayerColor
    {
        public TestLayer()
        {
            Color = new CCColor3B(CCColor4B.Blue);
            Opacity = 255;
        }
    }
}
