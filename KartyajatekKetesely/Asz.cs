using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KartyajatekKetesely
{
    class Asz
    {
        public static List<Asz> aszok = new List<Asz>();

        private string szin;

        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        private string szam;

        public string Szam
        {
            get { return szam; }
            set { szam = value; }
        }

        private string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            set { megnevezes = value; }
        }



        public Asz(string szin, string szam, string megnevezes)
        {
            if (szin == "treff" || szin == "pikk")
            {
                this.szin = "fekete";
            }
            else
            {
                this.szin = "piros";
            }

            this.szam = szam;
            this.megnevezes = megnevezes;
        }

        public static void Beolvasas()
        {
            StreamReader file = new StreamReader("pakli.txt");
            file.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                string[] adatok = file.ReadLine().Split(';');
                aszok.Add(new Asz(adatok[0], adatok[1], adatok[3]));
            }

            file.Close();
        }
    }
}
