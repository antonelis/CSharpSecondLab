﻿using System;
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
        public bool IsSquare
        {
            get
            {
                if (Size.X == Size.Y)
                {
                    return true;
                }
                else
                {
                    return false;
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
            return $"rectangle @({Center.X}, {Center.Y}): w = {Size.X}, h = {Size.Y}, IsSquare: {IsSquare}";
        }
    }
}
