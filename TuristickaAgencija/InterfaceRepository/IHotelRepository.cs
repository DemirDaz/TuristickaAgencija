using TuristickaAgencija.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IHotelRepository
    {
        IEnumerable<Hotel> GetAllHotels();
        void AddHotel(Hotel hotel);
        Hotel GetHotelById(int idHotela);
        void DeleteHotel(Hotel hotel);
        Hotel FindByImeHotela(string imeHotela);
    }
}
