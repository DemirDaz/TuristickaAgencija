using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IReferentRepository
    {
        IEnumerable<Referent>GetAllReferents();
        void AddReferents(Referent referent);
        Referent GetReferentsById(int IdReferenta);
        void DeleteReferents(Referent referent);
        Referent FindByIme(string Ime);
    }
}
