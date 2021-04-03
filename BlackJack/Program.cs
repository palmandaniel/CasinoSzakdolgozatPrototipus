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
        static List<LapBJ> lapok = new List<LapBJ>();

        static void Beolvas()
        { 
            StreamReader file = new StreamReader("pakli.txt");
            file.ReadLine();

            while (!file.EndOfStream)
            {
                string[] adatok = file.ReadLine().Split(';');
                lapok.Add(new LapBJ(adatok[0], adatok[1], int.Parse(adatok[2]), adatok[3]));
            }

            file.Close();
        }

        static void Main(string[] args)
        {

            LapBJ.Beolvasas();

            foreach (var l in LapBJ.pakli)
            {
                Console.WriteLine($"{l.Szin} - {l.Szam} - {l.Ertek} - {l.Megnevezes}");
            }

            Console.ReadLine();
        }
    }
}
