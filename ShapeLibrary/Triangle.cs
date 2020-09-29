using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    class Triangle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }
    }
}
