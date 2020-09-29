using System;
using ShapeLibrary;
using System.Numerics;

namespace ShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(new Circle(new Vector2(3.0f,4.0f),2.0f));

            Console.WriteLine(new Rectangle(new Vector2(3.0f,4.0f),4.0f));
            Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(3.0f, 4.0f)));
        }
    }
}
