using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IStudijskiProgramRepository
    {
        IEnumerable<StudijskiProgram> GetAllStudijskiPrograms();
        void AddStudijskiPrograms(StudijskiProgram studijskiProgram);
        StudijskiProgram GetStudijskiProgramsByIdStudProg(int IdStudProg);
        void DeleteStudijskiPrograms(StudijskiProgram studijskiProgram);
        StudijskiProgram FindByNaziv(string naziv);
    }
}
