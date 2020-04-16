using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*** Konvertierung in Zahlensysteme 
namespace test4AEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("TITEL DER ANWENDUNG");
            Console.ReadKey();
        }

        static void Titel(string titel)
        {
            int breite = Console.WindowWidth;
            int textlen = titel.Length;

            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (breite-textlen)/2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

        }

    }
}
