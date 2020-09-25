using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class KartePrevozRepository : IKartePrevozRepository
    {
        private Baza.DbTuristickaAgencija context;

        public KartePrevozRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddKartaPrevoza(KartePrevozaRepository karta)
        {
            this.context.KartePrevozas.Add(karta);
        }

        public void DeleteKartaPrevoza(KartePrevozaRepository karta)
        {
            this.context.KartePrevozas.Remove(karta);
        }

        public IEnumerable<KartePrevozaRepository> GetAllKartePrevoza()
        {
            return this.context.KartePrevozas.ToList();
        }

        public KartePrevozaRepository GetKartaPrevozaById(int idKarte)
        {
            return this.context.KartePrevozas.Where(c => c.idKarte == idKarte).FirstOrDefault();
        }
    }
}
