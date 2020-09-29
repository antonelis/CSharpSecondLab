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
            Center = new Vector3(center, 0);
            Radius = radius;
            Circumference = ((float)(Math.PI * radius * 2));
            Area = ((float)(Math.PI * Math.Pow(radius, 2)));
        }
        public override string ToString()
        {
            return $"circle @({Center.X}, {Center.Y}): r = {Radius}";
        }
    }
}
