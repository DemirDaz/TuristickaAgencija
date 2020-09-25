using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface ITurAranzmannRepository
    {
        IEnumerable<TurAranzmann> GetAllTurAranzmanns();
        void AddTurAranzmann(TurAranzmann aranzman);
        TurAranzmann GetTurAranzmannById(int aranzman);
        void DeleteTurAranzmann(TurAranzmann aranzman);
        IEnumerable<TurAranzmann> FindByDestinacija(string destinacija);
    }
}
