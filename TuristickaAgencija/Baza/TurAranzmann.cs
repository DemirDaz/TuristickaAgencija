using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class TurAranzmann
    {
        public int idAranzmana { get; set; }
        public string destinacija { get; set; }
        public DateTime datumPocetka { get; set; }
        public DateTime datumKraja { get; set; }
        public float cena { get; set; }
        public string nacinPlacanja { get; set; }
        
        public ICollection<RezAranzmana> RezAranzmanas { get; set; }
       
    
    }
}
