using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class RezAranzmanaRepository : IRezAranzmanaRepository
    {
        private Baza.DbTuristickaAgencija context;

        public RezAranzmanaRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddRezAranzmana(RezAranzmana rez)
        {
            this.context.RezAranzmanas.Add(rez);
            this.context.SaveChanges();
        }

        public void DeleteAranzman(RezAranzmana rez)
        {
            this.context.RezAranzmanas.Remove(rez);
            this.context.SaveChanges();
        }

        public IEnumerable<RezAranzmana> FindByAranzman(int idAranzmana)
        {
            return this.context.RezAranzmanas.Where(c => c.idAranzmana == idAranzmana).ToList();
        }

        public IEnumerable<RezAranzmana> GetAllRezAranzmanas()
        {
            return this.context.RezAranzmanas.ToList();
        }

        public RezAranzmana GetRezAranzmanaId(int rez)
        {
            return this.context.RezAranzmanas.Where(c => c.idRez == rez).FirstOrDefault();
        }
    }
}
