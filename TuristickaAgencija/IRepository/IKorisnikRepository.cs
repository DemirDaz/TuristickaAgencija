using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IKorisnikRepository
    {
        IEnumerable<Korisnik> GetAllKorisniks();
        void AddKorisniks(Korisnik korisnik);
        Korisnik GetKorisniksByKorisnickoIme(string korisnicko);
        void DeleteKorisniks(Korisnik korisnik);
        Korisnik FindByKorisnickoIme(string KorisnickoIme);
        bool CombinationExists(string KorisnickoIme, string Lozinka);
    }
}
