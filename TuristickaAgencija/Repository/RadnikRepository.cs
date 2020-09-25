using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class RadnikRepository : IRadnikRepository
    {
        private Baza.DbTuristickaAgencija context;

        public RadnikRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddRadnik(Radnik radnik)
        {
            this.context.Radniks.Add(radnik);
            this.context.SaveChanges();
        }

        public bool CombinationExists(string email, string sifra)
        {
            var count = context.Radniks.Where(x => x.email == email && x.sifra == sifra).Count();
            if (count == 1) return true;
            else return false;
        }

        public void DeleteRadnik(Radnik radnik)
        {
            this.context.Radniks.Remove(radnik);
            this.context.SaveChanges();
        }

        public IEnumerable<Radnik> GetAllRadniks()
        {
            return this.context.Radniks.ToList();
        }

        public Radnik GetRadnikByEmail(string email)
        {
            return this.context.Radniks.Where(c => c.email == email).FirstOrDefault();
        }

        public Radnik GetRadnikByJmbg(string jmbgRadnika)
        {
            return this.context.Radniks.Where(c => c.jmbgRadnika == jmbgRadnika).FirstOrDefault();
        }

        public bool IsManager(string email)
        {
            var count = context.Radniks.Where(x => x.email == email && x.pozicija == "menadzer").Count();
            if (count == 1) return true;
            else return false;
        }
    }
}
