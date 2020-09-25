using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class RezSmestajaRepository : IRezSmestajaRepository
    {
        private Baza.DbTuristickaAgencija context;

        public RezSmestajaRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddRezSmestaja(RezSmestaja rez)
        {
            this.context.RezSmestajas.Add(rez);
            this.context.SaveChanges();
        }

        public void DeleteRezSmestaja(RezSmestaja rez)
        {
            this.context.RezSmestajas.Remove(rez);
            this.context.SaveChanges();
        }

        public IEnumerable<RezSmestaja> GetAllRezSmestaja()
        {
            return this.context.RezSmestajas.ToList();
        }

        public IEnumerable<RezSmestaja> GetRezSmestajaByHotel(int idHotela)
        {
            return this.context.RezSmestajas.Where(c => c.idHotela == idHotela).ToList();
        }
    }
}
