using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IDepartmanRepository
    {
        IEnumerable<Departman> GetAllDepartmans();
        void AddDepartmans(Departman departman);
        Departman GetDepartmansById(int IdDepartmana);
        void DeleteDepartmans(Departman departman);
        Departman FindByNaziv(string Naziv);
    }
}
