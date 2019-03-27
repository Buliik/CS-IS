using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class Rezervace
    {
        public int idRez { get; set; }
        public DateTime datumVytvoreni {get; set; }
        public DateTime datumStrelby { get; set; }
        public int Zakaznik_idZak { get; set; }
        public int Prostor_idSpr { get; set; }
        public int Zbran_idZbr { get; set; }
    }
}
