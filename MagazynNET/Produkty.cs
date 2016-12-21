using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynNET
{
    class Produkty
    {
        public string nazwa { get; set; }
        public string producent { get; set; }
        public int ilosc_na_stanie { get; set; }
        public string kraj_pochodzenia { get; set; }
        public double cena { get; set; }
        public int zamowiona_ilosc { get; set; }
    }
}
