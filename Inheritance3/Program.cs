using Inheritance3.Entities;
using Inheritance3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("F2", CI));
            }
        }
    }
}
