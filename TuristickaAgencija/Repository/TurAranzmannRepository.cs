using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class TurAranzmannRepository : ITurAranzmannRepository
    {
        private Baza.DbTuristickaAgencija context;

        public TurAranzmannRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddTurAranzmann(TurAranzmann aranzman)
        {
            this.context.TurAranzmanns.Add(aranzman);
        }

        public void DeleteTurAranzmann(TurAranzmann aranzman)
        {
            this.context.TurAranzmanns.Remove(aranzman);
        }

        public IEnumerable<TurAranzmann> FindByDestinacija(string destinacija)
        {
            return this.context.TurAranzmanns.Where(c => c.destinacija == destinacija).ToList();
        }

        public IEnumerable<TurAranzmann> GetAllTurAranzmanns()
        {
            return this.context.TurAranzmanns.ToList();
        }

        public TurAranzmann GetTurAranzmannById(int aranzman)
        {
            return this.context.TurAranzmanns.Where(c => c.idAranzmana == aranzman).FirstOrDefault();
        }
    }
}
