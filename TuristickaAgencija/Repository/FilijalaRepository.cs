using System;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Repository
{
    class FilijalaRepository : IFilijalaRepository
    {
        private Baza.DbTuristickaAgencija context;

        public FilijalaRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddFilijala(Filijala filijala)
        {
            this.context.Filijalas.Add(filijala);
        }

        public void DeleteFilijala(Filijala filijala)
        {
            this.context.Filijalas.Remove(filijala);
        }

        public IEnumerable<Filijala> GetAllFilijalas()
        {
            return this.context.Filijalas.ToList();
        }

        public Filijala GetFilijalaById(int idFilijale)
        {
            return this.context.Filijalas.Where(c => c.PIB == idFilijale).FirstOrDefault();
        }
    }
}
