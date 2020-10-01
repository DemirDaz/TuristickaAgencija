using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class RezAranzmana
    {
        public int idRez { get; set; }
        public int idAranzmana { get; set; }
        
        public string jmbgKorisnika { get; set; }
        
        public DateTime datumRez { get; set; }
        public int brOsoba { get; set; }
       

        public float ukupnaCena { get; set; }
       
        public TurAranzmann TurAranzmann { get; set; }
        public Korisnik Korisnik { get; set; }

        
    }
}
