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
        static void Main(string[] args)
        {

            LapBJ.Beolvasas();

            //foreach (var l in LapBJ.pakli)
            //{
            //    Console.WriteLine($"{l.Szin} - {l.Szam} - {l.Ertek} - {l.Megnevezes}");
            //}

            LapBJ.Feltolt();

            foreach (var jP in LapBJ.JatszmaPakli)
            {
                 Console.WriteLine($"{jP.Szin} - {jP.Szam} - {jP.Ertek} - {jP.Megnevezes}");

            }

            Console.ReadLine();
        }
    }
}
