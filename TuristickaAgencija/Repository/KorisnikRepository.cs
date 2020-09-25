using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class KorisnikRepository : IKorisnikRepository
    {
        private Baza.DbTuristickaAgencija context;

        public KorisnikRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddKorisnik(Korisnik korisnik)
        {
            this.context.Korisniks.Add(korisnik);
        }

        public void DeleteKorisnik(Korisnik korisnik)
        {
            this.context.Korisniks.Remove(korisnik);
        }

        public Korisnik FindByEmail(string email)
        {
            return this.context.Korisniks.Where(c => c.email == email).FirstOrDefault();
        }

        public IEnumerable<Korisnik> GetAllKorisniks()
        {
            return this.context.Korisniks.ToList();
        }

        public Korisnik GetKorisnikByJmbg(string jmbg)
        {
            return this.context.Korisniks.Where(c => c.jmbgKorisnika == jmbg).FirstOrDefault();
        }
    }
}
