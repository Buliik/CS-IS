using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class Historie_zmen
    {
        public int Zid { get; set; }
        public DateTime Datum_zmeny { get; set; }
        public int Zbran_idZbr { get; set; }
        public string Nazev { get; set; }
        public string Typ_zbrane { get; set; }
        public double Raze { get; set; }
        public int Rok_vyroby { get; set; }
        public Zbran zbran { get; set; }
    }
}
