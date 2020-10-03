using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }
        public Vector2 Size { get; }
        public string IsSquare
        {
            get
            {
                if (Size.X == Size.Y)
                {
                    return "Square!";
                }
                else
                {
                    return "";
                }
            }
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.Center = new Vector3(center, 0);
            this.Area = size.X * size.Y;
            this.Size = size;
            this.Circumference = size.X * 2 + size.Y * 2;
        }

        public Rectangle(Vector2 center, float width)
        {
            this.Center = new Vector3(center, 0);
            this.Area = width * width;
            this.Size = new Vector2(width, width);
            this.Circumference = width * 4;
        }


        public override string ToString()
        {
            return $"Rectangle @({Center.X:F1}, {Center.Y:F1}): w = {Size.X:F1}, h = {Size.Y:F1}, {IsSquare}";
        }
    }
}
