using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IUnitOfWork
    {
        IDepartmanRepository Departmans { get; }
        IKorisnikRepository Korisniks { get; }
        IPolozeniISpitiRepository PolozeniISpitis { get; }
        IPredmetRepository Predmets { get; }
        IProfesorRepository Profesors { get; }
        IStudentRepository Students { get; }
        IReferentRepository Referents { get; }
        IStatusStudRepository StatusStudentas { get; } 
        IStudijskiProgramRepository StudijskiPrograms { get; }
        void Complete();
    }
}
