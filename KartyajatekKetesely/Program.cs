using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyajatekKetesely
{
    class Program
    {

        static void Main(string[] args)
        {
            Asz.Beolvasas();
            //foreach (var a in Asz.aszok)
            //{
            //    Console.WriteLine($"{ a.Megnevezes} - {a.Szin} ");
            //}
            bool jatek = true;
            string valasz;
            string korvege;

            while (jatek)
            {
                bool kor = true;
                while (kor)
                {
                    int index;
                    KorSorsolig(out valasz, out index);

                    if (valasz == Asz.aszok[index].Szin)
                    {
                        Console.Write("Eltaláltad! szeretnél újabb kört, ezzel megduplázni a nyerhető összeget? i/n");
                        korvege = Console.ReadLine();
                        if (korvege == "i")
                        {
                            KorSorsolig(out valasz, out index);
                        }
                        else
                        {
                            Console.WriteLine("Kiszálltál. Szeretnél újabb kört kezdeni? i/n");
                            if (true)
                            {

                            }
                        }
                    }
                    else
                    {
                        Console.Write("Nem nyert. Szeretnél újabb kört kezdeni? i/n");
                    }
                }
            }

            Console.ReadKey();
        }

        private static void KorSorsolig(out string valasz, out int index)
        {
            Console.Write("Következő lap színe?  p/f");
            string tipp = Console.ReadLine();
            if (tipp == "p")
            {
                valasz = "piros";
            }
            else
            {
                valasz = "fekete";
            }
            Random veletlen = new Random(Guid.NewGuid().GetHashCode());
            index = veletlen.Next(0, Asz.aszok.Count + 1);
        }
    }
}
