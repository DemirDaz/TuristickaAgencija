using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class KartePrevoza
    {
        public int idKarte { get; set; }
        public string destinacija { get; set; }
        public DateTime datum { get; set; }
        public float cena { get; set; }
        public string tipPrevoza { get; set; }

        public string jmbgKorisnika { get; set; }
        public Korisnik Korisnik { get; set; }

    }
}
