using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IRezAranzmanaRepository
    {
        IEnumerable<RezAranzmana> GetAllRezAranzmanas();
        void AddRezAranzmana(RezAranzmana rez);
        RezAranzmana GetRezAranzmanaId(int rez);
        void DeleteAranzman(RezAranzmana rez);
        IEnumerable<RezAranzmana> FindByAranzman(int idAranzmana);

    }
}
