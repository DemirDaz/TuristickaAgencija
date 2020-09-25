using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IRezSmestajaRepository
    {
        IEnumerable<RezSmestaja> GetAllRezSmestaja();
        void AddRezSmestaja(RezSmestaja rez);
        IEnumerable<RezSmestaja> GetRezSmestajaByHotel(int idHotela);
        void DeleteRezSmestaja(RezSmestaja rez);
    }
}
