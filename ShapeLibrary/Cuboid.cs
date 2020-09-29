using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    class Cuboid : Shape3D
    {
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

    }
}
