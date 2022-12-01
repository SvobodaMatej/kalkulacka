using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výtejte v kalkulačce");
            string pokračovat ="ano";
            while (pokračovat == "ano" )
            {
                Console.WriteLine("Zadejte 1 číslo");
                string cislo =Console.ReadLine();
                double a =Convert.ToDouble(cislo);
                Console.WriteLine("Zadejte 2 číslo");
                string cislo2 =Console.ReadLine(); 
                double b =Convert.ToDouble(cislo2);
                Console.WriteLine("1- součet");
                Console.WriteLine("2- podíl");
                Console.WriteLine("3-součin");
                Console.WriteLine("4-podíl");
                string menu = Console.ReadLine();
                int m = Convert.ToInt32(menu);
                double vysledek;
                switch (m)
                {
                    case 1:
                        vysledek = a + b;
                        Console.WriteLine(vysledek);
                        break;
                    case 2:
                        vysledek = a - b;
                        Console.WriteLine(vysledek);
                        break;

                    case 3:
                        vysledek = a * b;
                        Console.WriteLine(vysledek);
                        break;
                    case 4:
                        vysledek = a / b;
                        Console.WriteLine(vysledek);
                        break;
                }
                Console.WriteLine("Napiš ano pro pokračéváni");
                Console.WriteLine("Napiš ne pro konec");
                

                pokračovat= Console.ReadLine();











            }


        }
            
        }
    }

