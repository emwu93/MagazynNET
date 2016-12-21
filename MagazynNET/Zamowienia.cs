using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynNET
{
    class Zamowienia
    {
        public int id_zam { get; set; }
        public int id_klient { get; set; }
        public int id_produktu { get; set; }
        public int ilosc { get; set; }
        public DateTime data_zam { get; set; }

    }
}
