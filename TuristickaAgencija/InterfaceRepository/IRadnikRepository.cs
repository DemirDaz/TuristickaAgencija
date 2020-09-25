using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IRadnikRepository
    {
        IEnumerable<Radnik> GetAllRadniks();
        void AddRadnik(Radnik radnik);
        Radnik GetRadnikByJmbg(string jmbgRadnika);
        Radnik GetRadnikByEmail(string email);
        void DeleteRadnik(Radnik radnik);
        bool CombinationExists(string email, string sifra);
        bool IsManager(string email);

    }
}
