using System;
using ShapeLibrary;
using System.Numerics;
using System.Collections.Generic;

namespace ShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------------------------------------");

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }
            int index = 1;
            float sumOfCircumferenceInTriangles = 0.0f;
            float avgArea = 0.0f;
            float sumOfArea = 0.0f;
            float largestVolumeShape = 0.0f;
            
            foreach (Shape shape in shapes) 
            {
                Console.WriteLine($"{index} -> {shape}");
                index++;
                Console.WriteLine("--------------------------------------------------------------------");
                if (shape is Triangle triangle)
                {
                    sumOfCircumferenceInTriangles += triangle.Circumference;
                }
                sumOfArea += shape.Area;
                if (shape is Shape3D v && v.Volume > largestVolumeShape)
                {
                        largestVolumeShape = v.Volume;
                }
            }
            avgArea = sumOfArea / shapes.Count;
            Console.WriteLine($"Summan av omkretserna på alla trianglar i listan -> {sumOfCircumferenceInTriangles:F1}");
            Console.WriteLine("--------------------------------------------------------------------"); 
            Console.WriteLine($"Genomsnittliga arean av alla Shapes i listan -> {avgArea:F1}");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Shape3D som har störst volym av alla i listan -> {largestVolumeShape:F1}");
            Console.WriteLine("--------------------------------------------------------------------");
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));
            foreach (Vector2 v in t)
            {
                Console.WriteLine(v);
            }
            /*  Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
              Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), 4.0f));
              Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(3.0f, 4.0f)));
              Console.WriteLine(new Triangle(new Vector2(0.0f, 0.0f), new Vector2(3.0f, 3.0f), new Vector2(6.0f, 0.0f)));
              Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f), (new Vector3(4.0f, 5.0f, 2.0f))));
              Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f), 3.0f));
              Console.WriteLine(new Sphere(new Vector3(0.0f, 1.0f, 0.0f), 3.2f));
            */

        }
    }
}
