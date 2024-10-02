using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA13C_palma
{
    internal class Desszert
    {
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public bool Dijazott { get; set; }
        public int Ar { get; set; }
        public string Ertekesites { get; set; }

        public Desszert (string nev, string tipusa, bool dijazott, int ar, string ertekesites)
        {
            Nev = nev;
            Tipus = tipusa;
            Dijazott = dijazott;
            Ar = ar;
            Ertekesites = ertekesites;
        }

        public static List<Desszert> FromFile(string path)
        {
            List<Desszert> desszertek = new List<Desszert> ();

            string[] line = File.ReadAllLines(path);

            foreach (var l in line)
            {
                string[] d = l.Split(';');

                string Nev = d[0];
                string Tipus = d[1];
                bool Dijazott = bool.Parse(d[2]);
                int Ar = int.Parse(d[3]);
                string Ertekesites = d[4];

                Desszert desszert = new Desszert(Nev, Tipus, Dijazott, Ar, Ertekesites);
                desszertek.Add(desszert);
            }
            return desszertek;
        }

        public override string ToString()
        {
            return $"{Nev}, {Tipus}, {Dijazott}, {Ar}, {Ertekesites}";
        }

    }
}
