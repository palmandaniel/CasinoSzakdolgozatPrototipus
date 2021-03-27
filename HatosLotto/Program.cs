using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatosLotto
{
    class Program
    {

        public static int talalat = new int();
        static List<int> szamok = new List<int>();
        static List<int> sorsoltak = new List<int>();
        static List<int> tippeltek = new List<int>();

        static void Feltolt()
        {
            for (int i = 1; i < 46; i++)
            {
                szamok.Add(i);
            }
        }

        static List<int> Sorsol(List<int> sorsoltak)
        {
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                int szam = 0;
                szam = r.Next(1, 46).GetHashCode();
                if (!Tartalmazza(sorsoltak, szam))
                {
                    sorsoltak.Add(szam);
                }
                else
                {
                    i--;
                }
            }

            sorsoltak.Sort();
            return sorsoltak;
        }

        static List<int> Tipp(List<int> tippeltek)
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"Tipp {i}: ");
                int szam = int.Parse(Console.ReadLine());

                if (!Tartalmazza(tippeltek, szam) && 0 < szam && 91 > szam)
                {
                    tippeltek.Add(szam);
                }
                else
                {
                    i--;
                }
            }

            tippeltek.Sort();
            return tippeltek;
        }

        static bool Tartalmazza(List<int> lista, int szam)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == szam)
                {
                    return true;
                }
            }
            return false;
        }

        static int Vizsgal(List<int> sorsoltak, List<int> tippeltek)
        {
            int talalat = 0;

            for (int i = 0; i < sorsoltak.Count; i++)
            {
                for (int j = 0; j < tippeltek.Count; j++)
                {
                    if (sorsoltak[i] == tippeltek[j])
                    {
                        talalat++;
                    }
                }
            }
            return talalat;
        }

        static void Kifizet(int talalat)
        {
            switch (talalat)
            {
                case 1:
                    Console.WriteLine(1 * 10);
                    break;
                case 2:
                    Console.WriteLine(2 * 10);
                    break;
                case 3:
                    Console.WriteLine(3 * 10);
                    break;
                case 4:
                    Console.WriteLine(4 * 10);
                    break;
                case 5:
                    Console.WriteLine(5 * 10);
                    break;
                case 6:
                    Console.WriteLine(6*10);
                    break;
                
            }
        }

        static void Torles(List<int> sorsoltak, List<int> tippeltek, int talalat)
        {
            sorsoltak.Clear();
            tippeltek.Clear();
            talalat = 0;
        }

        static void Teszteles()
        {
            int talalat = 0;
            Torles(sorsoltak, tippeltek, talalat);
            Feltolt();
            Sorsol(sorsoltak);
            Console.WriteLine("*Számok*");
            foreach (var sz in szamok)
            {
                Console.Write($"{sz} - ");
            }
            Console.WriteLine("\n\n*Sorsolás*");
            foreach (var s in sorsoltak)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("*Tippelés*");
            Tipp(tippeltek);
            Console.WriteLine();
            foreach (var t in tippeltek)
            {
                Console.WriteLine($"{t} ");
            }
            Console.WriteLine();
            Console.WriteLine("*Találatok*");

            talalat = Vizsgal(sorsoltak, tippeltek);
            Console.WriteLine($"Találatok száma: {talalat}");
            Console.WriteLine();
            Console.WriteLine("*Vizsgálat - kifizetés*");
            Kifizet(talalat);
            Console.ReadKey();
        }

        static void Kor()
        {
            int talalat = 0;
            Torles(sorsoltak, tippeltek, talalat);
            //tét bekérése
            Feltolt();
            Sorsol(sorsoltak);
            Tipp(tippeltek);
            talalat = Vizsgal(sorsoltak, tippeltek);
            Vizsgal(sorsoltak, tippeltek);
            Kifizet(talalat);
        }

        private static void Jatek()
        {
            bool jatek = true;

            Console.WriteLine("Szeretnél játszani? i/n");
            string bekert = Console.ReadLine();
            if (bekert == "i")
            {
                jatek = true;
            }
            else
            {
                jatek = false;
            }
            while (jatek)
            {
                Kor();
                Console.WriteLine("Tippjeid: ");
                foreach (var t in tippeltek)
                {
                    Console.Write($"{t}  ");
                }
                Console.WriteLine();
                Console.WriteLine("Sorsoltak: ");
                foreach (var s in sorsoltak)
                {
                    Console.Write($"{s} ");
                }
                Console.WriteLine();
                talalat = Vizsgal(sorsoltak, tippeltek);
                Console.WriteLine($"Találataid száma: {talalat}");
                Kifizet(talalat);
                Console.WriteLine();
                Console.WriteLine("Szeretnél játszani? i/n");
                bekert = Console.ReadLine();
                if (bekert == "i")
                {
                    jatek = true;
                    Torles(sorsoltak, tippeltek, talalat);
                }
                else
                {
                    jatek = false;
                }
            }

        }

        static void Main(string[] args)
        {
            Jatek();
        }
    }
}
