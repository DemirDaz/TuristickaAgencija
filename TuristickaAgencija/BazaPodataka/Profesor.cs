using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class Profesor
    {
        public int IdProfesora { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme { get { return Ime + ' ' + Prezime; } set { } }


        public ICollection<PolozeniIspiti> PolozeniIspitis { get; set; }
    }
}
