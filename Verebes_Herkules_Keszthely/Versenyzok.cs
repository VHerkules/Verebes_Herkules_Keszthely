using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verebes_Herkules_Keszthely
{
    internal class Versenyzok
    {
        public string Nev { get; set; }
        public int Ev { get; set; }
        public int Rajtszam { get; set; }
        public string Nem { get; set; }
        public string Kategoria { get; set; }
        public TimeSpan Uszas { get; set; }
        public TimeSpan Elso { get; set; }
        public TimeSpan Kerekpar { get; set; }
        public TimeSpan Masodik { get; set; }
        public TimeSpan Futas {  get; set; }
        public int Eletkor => (int)(2024 - Ev);
        public override string ToString()
        {
            return $"{Nev}:{Ev}:{Rajtszam}:{Nem}:{Kategoria}:{Uszas}:{Elso}:{Kerekpar}:{Masodik}:{Futas}";
        }

        public Versenyzok(string row) 
        {
            var v = row.Split(';');
            Nev = v[0];
            Ev = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            Nem = v[3];
            Kategoria = v[4];
            Uszas = TimeSpan.Parse(v[5]);
            Elso = TimeSpan.Parse(v[6]);
            Kerekpar = TimeSpan.Parse(v[7]);
            Masodik = TimeSpan.Parse(v[8]);
            Futas = TimeSpan.Parse(v[9]);
        }
    }
}
