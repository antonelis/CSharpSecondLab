﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : Shape2D, IEnumerable
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        private Vector2[] vectors; 

        public Vector2 CornerA { get; }
        public Vector2 CornerB { get; }
        public Vector2 CornerC { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.CornerA = new Vector2(p1.X, p1.Y);
            this.CornerB = new Vector2(p2.X, p2.Y);
            this.CornerC = new Vector2(p3.X, p3.Y);
            vectors = new []{p1,p2,p3};
            float DistanceAtoB = (float)Math.Sqrt((float)Math.Pow((p2.X - p1.X), 2) + (float)Math.Pow((p2.Y - p1.Y), 2));
            float DistanceBtoC = (float)Math.Sqrt((float)Math.Pow((p3.X - p2.X), 2) + (float)Math.Pow((p3.Y - p2.Y), 2));
            float DistanceCtoA = (float)Math.Sqrt((float)Math.Pow((p1.X - p3.X), 2) + (float)Math.Pow((p1.Y - p3.Y), 2));

            Circumference = DistanceAtoB + DistanceBtoC + DistanceCtoA;

            var SemiParameter = Circumference / 2;

            this.Area = (float)Math.Sqrt(SemiParameter * (SemiParameter - DistanceAtoB) * (SemiParameter - DistanceBtoC) * (SemiParameter - DistanceCtoA));

            // Center  Ox = (Ax + Bx + Cx)/3 and Oy = (Ay + By + Cy)/3.

            Center = new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0);

        }
        public override string ToString()
        {
            return $"Triangle @({Center.X:F1}, {Center.Y:F1}): p1({CornerA.X:F1}, {CornerA.Y:F1}), p2({CornerB.X:F1}, {CornerB.Y:F1}), p3({CornerC.X:F1}. {CornerC.Y:F1})";
        }

        public IEnumerator GetEnumerator()
        {
            return vectors.GetEnumerator();
        }
    }
}

