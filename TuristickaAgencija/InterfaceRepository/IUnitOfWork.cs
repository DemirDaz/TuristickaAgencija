using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.InterfaceRepository
{
    interface IUnitOfWork
    {
        IFilijalaRepository Filijalas { get; }
        IHotelRepository Hotels { get; }
        IKartePrevozRepository KartePrevozs { get; }
        IKorisnikRepository Korisniks { get; }
        IRadnikRepository Radniks { get; }
        IRezAranzmanaRepository RezAranzmanas { get; }
        IRezSmestajaRepository RezSmestajas { get; }
        ITurAranzmannRepository TurAranzmans { get; }
       
    
        void Complete();
    }
}
