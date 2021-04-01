using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            KockaPokerKocka jatekos = new KockaPokerKocka();
            KockaPokerKocka gep = new KockaPokerKocka();

            bool jatek = true;

            while (jatek)
            {
                Console.Write("Szeretnél játszani? i/n  ");
                string valasz = Console.ReadLine();
                Console.WriteLine();

                if (valasz=="i")
                {
                    jatek = true;
                    Console.Write($"Játékos:");
                    jatekos.EgyDobas();
                    jatekos.Kiiras();
                    Console.WriteLine();
                    Console.Write($"Gép: ");
                    gep.EgyDobas();
                    gep.Kiiras();
                    Console.WriteLine();
                    if (jatekos.Pont>gep.Pont)
                    {
                        Console.WriteLine($"Játékos nyert, {jatekos.Pont} elérésével, gép pontjai: {gep.Pont}");
                    }
                    else if (jatekos.Pont < gep.Pont)
                    {
                        Console.WriteLine($"Gép nyert, {gep.Pont} elérésével, játékos pontjai: {jatekos.Pont}");
                    }
                    else
                    {
                        Console.WriteLine($"Döntetlen, mindkét fél {jatekos.Pont} pontot ért el");
                    }
                    Console.WriteLine();
                    Console.WriteLine("****");
                    Console.WriteLine();
                }
                else
                {
                    jatek = false;
                    Console.WriteLine("Viszontlátásra");
                }
            }

            
            Console.ReadKey();
        }
    }
}
