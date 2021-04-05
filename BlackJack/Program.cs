using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack
{
    class Program
    {
        static List<LapBJ> jatszmaPakli = new List<LapBJ>();
        static List<LapBJ> jatekosPakli = new List<LapBJ>();
        static List<LapBJ> gepPakli = new List<LapBJ>();

        static void Feltolt()
        {
            foreach (var p in LapBJ.pakli)
            {
                jatszmaPakli.Add(new LapBJ(p.Szin, p.Szam, p.Ertek, p.Megnevezes));
            }
        }

        static void Osztas(int db, List<LapBJ> lista)
        {
            Random veletlenindex = new Random(Guid.NewGuid().GetHashCode());
            int lap = 0;

            for (int j = 0; j < db; j++)
            {
                lap = veletlenindex.Next(0, jatszmaPakli.Count + 1);
                for (int i = 0; i < jatszmaPakli.Count; i++)
                {
                    if (lap == i)
                    {
                        lista.Add(new LapBJ(jatszmaPakli[i].Szin, jatszmaPakli[i].Szam, jatszmaPakli[i].Ertek, jatszmaPakli[i].Megnevezes));
                        jatszmaPakli.RemoveAt(i);
                    }
                }
            }
        }

        static bool LapotKer()
        {
            Console.WriteLine("K�rsz lapot? i/n");
            string valasz = Console.ReadLine();

            if (valasz == "i")
            {
                Osztas(1, jatekosPakli);
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Ertekel(List<LapBJ> lista)
        {
            int sum = 0;
            int aszdb = 0;

            foreach (var l in lista)
            {
                if (l.Szam == "Asz")
                {
                    aszdb++;
                }

                sum += l.Ertek;

            }

            //foreach (var l in lista)
            //{
            //    if (l.Szam == "Asz" && sum > 21)
            //    {
            //        sum = sum - (aszdb * 10);
            //    } 
            //}

            return sum;
        }

        //static void AszVizsgalat(List<LapBJ> lista)
        //{
        //    foreach (var l in lista)
        //    {
        //        if (l.Szam == "Asz" && Ertekel(lista) > 21)
        //        {
        //            for (int i = 0; i < lista.Count; i++)
        //            {
        //                if (lista[i].Szam == "Asz")
        //                {
        //                    lista[i].Ertek = 1;
        //                }
        //            }
        //        }
        //    }
        //}

        static string Gyozteskereses(List<LapBJ> lista)
        {
            if (Ertekel(lista) == 21)
            {
                return "BlackJack";
            }
            else if (Ertekel(lista) > 21)
            {
                return "Vesztes leoszt�s, nagyobb mint 21";
            }
            else
            {
                return "";
            }
        }

        static int KulonbsegKereses(List<LapBJ> lista)
        {
            return 21 - Ertekel(lista);
        }

        static void GepKer()
        {
            if (Ertekel(gepPakli)<15)
            {
                Osztas(1, gepPakli);
            }
            else if (Ertekel(gepPakli)<17)
            {
                Random vel = new Random();
                int velszam = vel.Next(0, 101);
                if (velszam%2==0)
                {
                    Osztas(1, gepPakli);
                }
            }
            else if (Ertekel(gepPakli)<18)
            {
                Random vel = new Random();
                int velszam = vel.Next(0, 101);
                if (velszam%5==0)
                {
                    Osztas(1, gepPakli);
                }
            }
        }

        static void Main(string[] args)
        {

            LapBJ.Beolvasas();
            Feltolt();


            Osztas(2, jatekosPakli);
            Console.WriteLine(Ertekel(jatekosPakli));
            Osztas(2, gepPakli);
            for (int i = 0; i < jatekosPakli.Count; i++)
            {
                Console.WriteLine(jatekosPakli[i].Megnevezes);
            }
            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                if (Gyozteskereses(jatekosPakli) == "BlackJack" || Gyozteskereses(gepPakli) == "BlackJack")
                {

                    if (Gyozteskereses(jatekosPakli) == "BlackJack")
                    {
                        Console.WriteLine("J�t�kos nyert");
                        Terites();
                    }
                    else
                    {
                        Console.WriteLine("G�p nyert");
                        Terites();
                    }
                    break;
                }
                else if (Gyozteskereses(jatekosPakli) == "Vesztes leoszt�s, nagyobb mint 21" || Gyozteskereses(gepPakli) == "Vesztes leoszt�s, nagyobb mint 21")
                {
                    if (Gyozteskereses(jatekosPakli) == "Vesztes leoszt�s, nagyobb mint 21")
                    {
                        Console.WriteLine("J�t�kos vesz�tett");
                        Terites();
                    }
                    else
                    {
                        Console.WriteLine("G�p vesz�tett");
                        Terites();
                    }
                    break;
                }


                if (LapotKer())
                {
                    foreach (var l in jatekosPakli)
                    {
                        Console.WriteLine(l.Megnevezes);
                    }
                    Console.WriteLine(Ertekel(jatekosPakli));
                    i--;
                }
                else
                {

                    Console.WriteLine("meg�llt�l");
                    GepKer();
                    Terites();
                }
            }

            Console.ReadLine();
        }

        private static void Terites()
        {
            Console.WriteLine("Te oszt�sod: ");
            foreach (var jP in jatekosPakli)
            {
                Console.Write($"{jP.Megnevezes}  ");
            }
            Console.WriteLine($"�rt�ke {Ertekel(jatekosPakli)}");
            Console.WriteLine("\nG�p oszt�sa");
            foreach (var gP in gepPakli)
            {
                Console.Write($"{gP.Megnevezes}  ");
            }
            Console.WriteLine($"�rt�ke {Ertekel(gepPakli)}");

            Console.WriteLine(KulonbsegKereses(jatekosPakli));
            Console.WriteLine(KulonbsegKereses(gepPakli));
        }
    }
}
