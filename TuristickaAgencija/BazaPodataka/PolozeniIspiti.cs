using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class PolozeniIspiti
    {
        public int IdIspit { get; set; }
        public string brIndeksa { get; set; }
        
        public int Sifra { get; set; }
        public string ispitniRok { get; set; }
        public DateTime datumPolaganja { get; set; }
        private int ocena;
        public int Ocena
        {
            get { return ocena; }
            set
            {
                if (value < 6 || value > 10) ocena = 5;
                else
                    ocena = value;
            }
        }
        public int idProfesora { get; set; }
        public Predmet Predmet { get; set; }
        public Profesor Profesor { get; set; }
    }
}
