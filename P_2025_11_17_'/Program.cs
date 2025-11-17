using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_2025_11_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az a-t: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a b-t: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Add meg a c-t: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (a == 0)
            {
                Console.WriteLine("Ez nem másodfokú egyenlet (a nem lehet 0).");
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Két valós gyök: x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök: x = {x}");
            }
            else
            {
                Console.WriteLine("Nincs valós gyök!");
            }

            Console.ReadKey();
        }
    }
}