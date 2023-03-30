using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programovani_matematika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte požadavek z výběru:");
            Console.WriteLine("a - Obvod kruhu");
            Console.WriteLine("b - Odmocnina");
            Console.WriteLine("c - Mocnina");
            Console.WriteLine("d - Obvod a obsah čtverce");
            char volba = char.Parse(Console.ReadLine());

            if (volba == 'a')
            {
                Console.WriteLine("Zadejte poloměr kruhu: ");
                int r = Convert.ToInt32(Console.ReadLine());
                double vysledek = 2 * Math.PI * r;
                Console.WriteLine("Výsledek: " + vysledek);
            }
            else if (volba == 'b')
            {
                Console.WriteLine("Zadejte číslo pro výpočet druhé odmocniny: ");
                double x = double.Parse(Console.ReadLine());
                if (x >= 0)
                {
                    double vysledek = Math.Sqrt(x);
                    Console.WriteLine("Výsledek: " + vysledek);
                }
                else
                {
                    Console.WriteLine("Hodnota musí být větší než nula.");
                }

            }
            else if (volba == 'c')
            {
                Console.WriteLine("Zadejte základ čísla (x): "); // x na y (5 na 2)
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadej exponent (y): ");
                double n = double.Parse(Console.ReadLine());
                double vysledek = Math.Pow(x, n);
                Console.WriteLine("Výsledek: " + vysledek);
            }
            else if (volba == 'd')
            {
                Console.WriteLine("Zadejte délku strany v jednotce cm: ");
                double a = double.Parse(Console.ReadLine());
                if (a > 0)
                {
                    double vysledek1 = 4 * a;
                    double vysledek2 = a * a;
                    Console.WriteLine("Obvod čtverce: " + vysledek1 + "cm");
                    Console.WriteLine("Obsah čtverce: " + vysledek2 + "cm^2");
                }
                else
                {
                    Console.WriteLine("Hodnota musí být větší než nula.");
                }

            }
            else
            {
                Console.WriteLine("Na výběr jsou pouze možnosti: a, b, c, d.");
            }
            Console.ReadKey();
        }
    }
}
