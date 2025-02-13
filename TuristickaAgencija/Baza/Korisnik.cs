﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class Korisnik
    {
        public string jmbgKorisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public ICollection<RezAranzmana> RezAranzmanas { get; set; }
        
        public ICollection<RezSmestaja> RezSmestajas { get; set; }
        public ICollection<KartePrevoza> KartePrevozas { get; set; }
    }
}
