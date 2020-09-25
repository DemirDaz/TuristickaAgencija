using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IProfesorRepository
    {
        IEnumerable<Profesor> GetAllProfesors();
        void AddProfesors(Profesor profesor);
        Profesor GetProfesorsByIdProfesora(int IdProfesora);
        void DeleteProfesors(Profesor profesor);
        Profesor FindByIme(string Ime);
    }
}
