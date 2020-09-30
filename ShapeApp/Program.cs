using System;
using ShapeLibrary;
using System.Numerics;

namespace ShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
            Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), 4.0f));
            Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(3.0f, 4.0f)));
            Console.WriteLine(new Triangle(new Vector2(0.0f, 0.0f), new Vector2(3.0f, 3.0f), new Vector2(6.0f, 0.0f)));
            Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f), (new Vector3(4.0f, 5.0f, 2.0f))));
            Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f), 3.0f));
            Console.WriteLine(new Sphere(new Vector3(0.0f, 1.0f, 0.0f), 3.2f));

        }
    }
}
