using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class RezSmestaja
    {
        public int idRez { get; set; }
        public int idHotela { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
        public string vrstaUsluge { get; set; }

    }
}
