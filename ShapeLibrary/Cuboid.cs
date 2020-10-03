using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Vector3 Size { get; }

        public Cuboid(Vector3 center, Vector3 size)
        {
            Volume = size.X * size.Y * size.Z;
            Center = new Vector3(center.X, center.Y, center.Z);
            Area = 2 * (size.X * size.Y) + 2 * (size.Z * size.Y) + 2 * (size.X * size.Z);
            Size = size;
        }
        public Cuboid(Vector3 center, float width)
        {
            Center = new Vector3(center.X, center.Y, center.Z);
            Area = width * width * 6;
            Volume = width * width * width;
            Size = new Vector3(width, width, width);
        }
        public string IsCube
        {
            get
            {
                if (Size.X == Size.Y)
                {
                    return "Cube!";
                }
                else
                {
                    return "";
                }
            }
        }
        public override string ToString()
        {
            return $"Cuboid @({Center.X:F1}, {Center.Y:F1}, {Center.Z:F1}): w = {Size.X:F1}, h = {Size.Y:F1}, l = {Size.Z:F1} {IsCube}";
        }

    }
}
