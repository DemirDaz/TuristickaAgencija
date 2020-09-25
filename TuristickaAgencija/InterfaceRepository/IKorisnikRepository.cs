using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IKorisnikRepository
    {
        IEnumerable<Korisnik> GetAllKorisniks();
        void AddKorisnik(Korisnik korisnik);
        Korisnik GetKorisnikByJmbg(string jmbg);
        void DeleteKorisnik(Korisnik korisnik);
        Korisnik FindByEmail(string email);
    }
}
