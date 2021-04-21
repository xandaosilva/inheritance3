using System;
using System.Globalization;
namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                string color = Console.ReadLine();

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CI);
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CI);
                }

                Console.WriteLine("\nSHAPE AREAS:");
                foreach ()
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
