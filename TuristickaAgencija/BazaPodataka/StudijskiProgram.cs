using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class StudijskiProgram
    {
        public int IdStudProg { get; set; }
        public string ImeSP { get; set; }
        public int IdDepartmana { get; set; }

        public int IdReferenta { get; set; }
        public Departman Departman { get; set; }
        public ICollection<Predmet> Predmets { get; set; }
    }
}
