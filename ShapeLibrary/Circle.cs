using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public float Radius { get; }

        public Circle(Vector2 center, float radius)
        {
            this.Center = new Vector3(center, 0);
            this.Radius = radius;
            this.Circumference = ((float)(Math.PI * radius * 2));
            this.Area = ((float)(Math.PI * Math.Pow(radius, 2)));
        }

        public override string ToString()
        {
            return $"Circle @({Center.X:F1}, {Center.Y:F1}): r = {Radius:F1}";
        }
    }
}
