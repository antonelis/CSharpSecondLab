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

            // https://www.youtube.com/watch?list=PLshJtXCW6HtWsl-thJ6LWBRGTwP3GdWJx&time_continue=8&v=weW3SHQ9K8g&feature=emb_logo
            float FirstSideWithFirstAndSecondCorner = (float)Math.Sqrt((float)Math.Pow((p2.X - p1.X), 2) + (float)Math.Pow((p2.Y - p1.Y),2));
            float SecondSideWithSecondAndThirdCorner = (float)Math.Sqrt((float)Math.Pow((p3.X - p2.X), 2) + (float)Math.Pow((p3.Y - p2.Y), 2));
            float ThirdSideWithThirdAndFirstCorner = (float)Math.Sqrt((float)Math.Pow((p1.X - p3.X), 2) + (float)Math.Pow((p1.Y - p3.Y), 2));

            Circumference = FirstSideWithFirstAndSecondCorner + SecondSideWithSecondAndThirdCorner + ThirdSideWithThirdAndFirstCorner;
            var SemiParameter = Circumference / 2;

            this.Area = (float)Math.Sqrt(SemiParameter * (SemiParameter - FirstSideWithFirstAndSecondCorner) * (SemiParameter - SecondSideWithSecondAndThirdCorner) * (SemiParameter - ThirdSideWithThirdAndFirstCorner));

            // Center


        }
    }
}
