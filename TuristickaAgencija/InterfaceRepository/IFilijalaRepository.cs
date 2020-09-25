using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IFilijalaRepository
    {
        IEnumerable<Filijala> GetAllFilijalas();
        void AddFilijala(Filijala filijala);
        Filijala GetFilijalaById(int idFilijale);
        void DeleteFilijala(Filijala filijala);
        //Filijala FindByNaziv(string Naziv);
    }
}
