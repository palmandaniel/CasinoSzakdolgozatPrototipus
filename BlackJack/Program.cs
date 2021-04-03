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

        static void Osztas(int db)
        {
            Random jvel = new Random(Guid.NewGuid().GetHashCode());
            Random gvel = new Random(Guid.NewGuid().GetHashCode());


            for (int i = 1; i <= db; i++)
            {
                int geplap = gvel.Next(0, jatszmaPakli.Count + 1);
                int jatlap = jvel.Next(0, jatszmaPakli.Count + 1);

                if (jvel != gvel)
                {
                    jatekosPakli.Add(new LapBJ(jatszmaPakli[jatlap].Szin, jatszmaPakli[jatlap].Szam, jatszmaPakli[jatlap].Ertek, jatszmaPakli[jatlap].Megnevezes));
                    gepPakli.Add(new LapBJ(jatszmaPakli[geplap].Szin, jatszmaPakli[geplap].Szam, jatszmaPakli[geplap].Ertek, jatszmaPakli[geplap].Megnevezes));

                    jatszmaPakli.RemoveAt(jatlap);
                    jatszmaPakli.RemoveAt(geplap);
                }
                else
                {
                    i--;
                }
                geplap = 0;
                jatlap = 0;
            }

        }

        static void Main(string[] args)
        {

            LapBJ.Beolvasas();
            Feltolt();

            //foreach (var jP in jatszmaPakli)
            //{
            //     Console.WriteLine($"{jP.Szin} - {jP.Szam} - {jP.Ertek} - {jP.Megnevezes}");
            //}

            Osztas(9);
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
