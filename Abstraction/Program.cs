using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 7);

            var resultRectangleArea = r.Area();
            var resultRectanglePerimeter = r.Perimeter();

            Console.WriteLine($"Povrsina pravougaonika je: {resultRectangleArea}");

            Console.WriteLine($"Obim Pravougaonika je {resultRectanglePerimeter}");


            Console.WriteLine($"==========================");

            Circle c = new Circle(11);

            var resultCircleArea = c.Area();
            var resultCirclePerimeter = c.Perimeter();

            Console.WriteLine($"Povrsina kruga je: {resultCircleArea}");

            Console.WriteLine($"Obim kruga je: {resultCirclePerimeter}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
