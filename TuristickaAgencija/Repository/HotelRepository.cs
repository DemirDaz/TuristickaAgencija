using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;

namespace TuristickaAgencija.Repository
{
    class HotelRepository : IHotelRepository
    {
        private Baza.DbTuristickaAgencija context;

        public HotelRepository(Baza.DbTuristickaAgencija context)
        {
            this.context = context;
        }
        public void AddHotel(Hotel hotel)
        {
            this.context.Hotels.Add(hotel);
            this.context.SaveChanges();
        }

        public void DeleteHotel(Hotel hotel)
        {
            this.context.Hotels.Remove(hotel);
            this.context.SaveChanges();
        }

        public Hotel FindByImeHotela(string imeHotela)
        {
            return this.context.Hotels.Where(c => c.ime == imeHotela).FirstOrDefault();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return this.context.Hotels.ToList();
        }

        public Hotel GetHotelById(int idHotela)
        {
            return this.context.Hotels.Where(c => c.idHotela == idHotela).FirstOrDefault();
        }
    }
}
