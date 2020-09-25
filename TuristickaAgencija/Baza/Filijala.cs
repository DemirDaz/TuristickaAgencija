using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class Filijala
    {
        public int PIB { get; set; }
        public string naziv { get; set; }
        public string sediste { get; set; }
        public string sifraMenadzera { get; set; }
        public Radnik GlavniMenadzer { get; set; }
        public string maticniBroj { get; set; }
        public string racun { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string webAdresa { get; set; }
        public ICollection<Radnik> Radniks { get; set; }


    }
}
