using System;

namespace P_2025_11_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            try
            {
                Console.Write("Add meg az a-t: ");
                a = double.Parse(Console.ReadLine());
                if (a < 0) throw new Exception("A szám nem lehet negatív!");

                Console.Write("Add meg a b-t: ");
                b = double.Parse(Console.ReadLine());
                if (b < 0) throw new Exception("A szám nem lehet negatív!");

                Console.Write("Add meg a c-t: ");
                c = double.Parse(Console.ReadLine());
                if (c < 0) throw new Exception("A szám nem lehet negatív!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás formátum! Csak számot adhatsz meg.");
                Console.ReadKey();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba: " + ex.Message);
                Console.ReadKey();
                return;
            }

            double d = b * b - 4 * a * c;

            try
            {
                if (a <= 0)
                {
                    throw new Exception("A paraméter nem lehet 0 vagy negatív!");
                }

                double d = b * b - 4 * a * c;

                if (d > 0)
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
                    throw new Exception("A diszkrimináns negatív, nincs valós gyök!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
