using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public float Radius { get; }

        public Sphere(Vector3 center, float radius)
        {
            //   V = 4/3πr3     A=4πr2
            Area = 4.0f * (float)(Math.PI) * (float)Math.Pow(radius, 2);
            Volume = 4.0f / 3.0f * (float)(Math.PI) * (float)Math.Pow(radius, 3);
            Radius = radius;
            Center = new Vector3(center.X, center.Y, center.Z);
        }
        public override string ToString()
        {
            return $"Sphere @({Center.X:F1}, {Center.Y:F1}, {Center.Z:F1}): r = {Radius:F1}";
        }
    }
}
