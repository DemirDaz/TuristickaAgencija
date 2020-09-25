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
        IEnumerable<KartePrevoza> GetAllKartePrevoza();
        void AddKartaPrevoza(KartePrevoza karta);
        KartePrevoza GetKartaPrevozaById(int idKarte);
        void DeleteKartaPrevoza(KartePrevoza karta);
        
    }
}
