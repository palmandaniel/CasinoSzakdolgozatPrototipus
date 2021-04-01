using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockajatekNagyobbMint
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jatek = true;

            KockajatekKocka jatekos = new KockajatekKocka();
            KockajatekKocka gep = new KockajatekKocka();

            while (jatek)
            {
                Console.Write("Szeretnél játszani?  i/n  ");
                string valasz = Console.ReadLine();

                if (valasz == "i")
                {
                    int kockaszam = 0;
                    jatek = true;
                    Console.Write("Hány kockával szeretnél játszani?  ");
                    kockaszam = int.Parse(Console.ReadLine());

                    jatekos.Dobas(kockaszam);
                    gep.Dobas(kockaszam);

                    Console.WriteLine("Te dobásod: ");
                    jatekos.Kiir();
                    Console.WriteLine();
                    Console.WriteLine("Gép dobása: ");
                    gep.Kiir();

                    if (jatekos.Kiertekel() > gep.Kiertekel())
                    {
                        Console.WriteLine($"\nJátékos nyert, dobásod értéke: {jatekos.Kiertekel()}, gép dobása: {gep.Kiertekel()}");
                    }
                    else if (jatekos.Kiertekel() < gep.Kiertekel())
                    {
                        Console.WriteLine($"\nGép nyert, dobása értéke: {gep.Kiertekel()}, te dobásod: {jatekos.Kiertekel()}");
                    }
                    else
                    {
                        Console.WriteLine($"\nDöntetlen, mindkét játékos dobásának értéke: {jatekos.Kiertekel()}");
                    }

                }
                else
                {
                    jatek = false;
                    Console.WriteLine("\nViszontlátásra!");
                }
            }

            Console.ReadKey();
        }
    }
}

