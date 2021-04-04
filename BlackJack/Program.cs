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

        static bool Tartalmazza(List<LapBJ> lista, int szam)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Megnevezes == lista[szam].Megnevezes)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

            LapBJ.Beolvasas();
            Feltolt();

            //foreach (var jP in jatszmaPakli)
            //{
            //     Console.WriteLine($"{jP.Szin} - {jP.Szam} - {jP.Ertek} - {jP.Megnevezes}");
            //}

            Osztas(9, jatekosPakli);
            Osztas(9, gepPakli);
            for (int i = 0; i < jatekosPakli.Count; i++)
            {
                Console.WriteLine(jatekosPakli[i].Megnevezes);
            }
            Console.WriteLine();
            for (int i = 0; i < gepPakli.Count; i++)
            {
                Console.WriteLine(gepPakli[i].Megnevezes);
            }

            int db = 0;

            for (int i = 0; i < jatekosPakli.Count; i++)
            {
                for (int j = 0; j < gepPakli.Count; j++)
                {
                    if (jatekosPakli[i].Megnevezes == gepPakli[j].Megnevezes)
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(db);

            Console.ReadLine();
        }
    }
}
