using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Vector2 FirstCorner { get; }
        public Vector2 SecondCorner { get; }
        public Vector2 ThirdCorner { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.FirstCorner = new Vector2(p1.X, p1.Y);
            this.SecondCorner = new Vector2(p2.X, p2.Y);
            this.ThirdCorner = new Vector2(p3.X, p3.Y);


        }
    }
}
