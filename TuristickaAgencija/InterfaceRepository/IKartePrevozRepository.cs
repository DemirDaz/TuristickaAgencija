using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IKartePrevozRepository
    {
        IEnumerable<KartePrevozaRepository> GetAllKartePrevoza();
        void AddKartaPrevoza(KartePrevozaRepository karta);
        KartePrevozaRepository GetKartaPrevozaById(int idKarte);
        void DeleteKartaPrevoza(KartePrevozaRepository karta);
        
    }
}
