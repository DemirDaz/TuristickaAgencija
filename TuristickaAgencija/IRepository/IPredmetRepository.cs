using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IPredmetRepository
    {
        IEnumerable<Predmet> GetAllPredmets();
        void AddPredmets(Predmet predmet);
        Predmet GetPredmetsBySifra(int Sifra);
        void DeletePredmets(Predmet predmet);
        Predmet FindByNaziv(string naziv);
    }
}
