using TuristickaAgencija.InterfaceRepository;
using TuristickaAgencija.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class UnitOfWork : IUnitOfWork
    {
        private Baza.DbTuristickaAgencija context;
        private FilijalaRepository filijala;
        private KorisnikRepository korisnik;
        private RadnikRepository radnik;
        private HotelRepository hotel;
        private KartePrevozRepository kartePrevoza;
        private RezAranzmanaRepository rezAranzmana;
        private RezSmestajaRepository rezSmestaja;
        private TurAranzmannRepository turAranzmann;
       
        public UnitOfWork(DbTuristickaAgencija context)
        {
            this.context = context;
        }
       


        public IKorisnikRepository Korisniks
        {
            get
            {
                return korisnik ?? (korisnik = new KorisnikRepository(context));
            }
        }

        public IFilijalaRepository Filijalas {
            get
            {
                return filijala ?? (filijala = new FilijalaRepository(context));
            }
        }

        public IHotelRepository Hotels
        {
            get
            {
                return hotel ?? (hotel = new HotelRepository(context));
            }
        }

        public IKartePrevozRepository KartePrevozs
        {
            get
            {
                return kartePrevoza ?? (kartePrevoza = new KartePrevozRepository(context));
            }
        }

        public IRadnikRepository Radniks
        {
            get
            {
                return radnik ?? (radnik = new RadnikRepository(context));
            }
        }

        public IRezAranzmanaRepository RezAranzmanas
        {
            get
            {
                return rezAranzmana ?? (rezAranzmana = new RezAranzmanaRepository(context));
            }
        }

        public IRezSmestajaRepository RezSmestajas
        {
            get
            {
                return rezSmestaja ?? (rezSmestaja = new RezSmestajaRepository(context));
            }
        }

        public ITurAranzmannRepository TurAranzmans
        {
            get
            {
                return turAranzmann ?? (turAranzmann = new TurAranzmannRepository(context));
            }
        }

        public void Complete()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
