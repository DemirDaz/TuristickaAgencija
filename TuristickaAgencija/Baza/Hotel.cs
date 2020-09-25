using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class Hotel
    {
        public int idHotela { get; set; }
        public string ime { get; set; }
        public string lokacija { get; set; }
        public string kategorija { get; set; }
        public string email { get; set; }
        public string webadresa { get; set; }

        public ICollection<RezSmestaja> RezSmestajas { get; set; }

    }
}
