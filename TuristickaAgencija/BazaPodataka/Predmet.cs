using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class Predmet
    {
        public int Sifra { get; set; }
        public string NazivPredmeta { get; set; }
        public string BrSemestra { get; set; }
        public int IdStudProg { get; set; }

        public string Profesor1 { get; set; }
        public string Profesor2 { get; set; }

        public StudijskiProgram StudijskiProgram { get; set; }

        public ICollection<PolozeniIspiti> PolozeniIspitis { get; set; }
    
    }
}
