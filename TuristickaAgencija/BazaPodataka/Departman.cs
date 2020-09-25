using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class Departman
    {
        public int IdDepartmana { get; set; }
        public string ImeDepartmana { get; set; }
        public ICollection<StudijskiProgram> StudijskiPrograms { get; set; }

    }
}
