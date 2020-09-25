using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class Radnik
    {
        public string jmbgRadnika { get; set; }
        public string ime { get; set; }
        public string imeRoditelja { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string strucnaSprema { get; set; }
        public string pozicija { get; set; }
        public int sifraFilijale { get; set; }
        public Filijala Filijala { get; set; }
        public string adresa { get; set; }
        public string email { get; set; } //auth
        public string sifra { get; set; } //auth
        public string sluzbeniTel { get; set; }
        public string privatniTel { get; set; }
        public ICollection<Filijala> Filijalas { get; set; }
        //filijala ima kljuc radnik
    }
}
