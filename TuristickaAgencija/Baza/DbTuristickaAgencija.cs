using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Baza
{
    class DbTuristickaAgencija : DbContext
    {
        public DbSet<Filijala> Filijalas { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<KartePrevoza> KartePrevozas { get; set; }
        public DbSet<Korisnik> Korisniks { get; set; }
        public DbSet<Radnik> Radniks { get; set; }
        public DbSet<RezAranzmana> RezAranzmanas { get; set; }
        public DbSet<RezSmestaja> RezSmestajas { get; set; }
        public DbSet<TurAranzmann> TurAranzmanns  { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Radnik>().HasKey(k => k.jmbgRadnika);
            modelBuilder.Entity<Radnik>().Property(k => k.ime).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Radnik>().Property(k => k.imeRoditelja).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Radnik>().Property(k => k.prezime).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Radnik>().Property(k => k.datumRodjenja).IsRequired();
            modelBuilder.Entity<Radnik>().Property(k => k.strucnaSprema).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Radnik>().Property(k => k.pozicija).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Radnik>().Property(k => k.sifraFilijale).IsRequired();
            modelBuilder.Entity<Radnik>().HasRequired(b => b.Filijala).WithMany(a => a.Radniks).HasForeignKey(c => c.sifraFilijale).WillCascadeOnDelete(false); ;
           
            modelBuilder.Entity<Radnik>().Property(k => k.adresa).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Radnik>().Property(k => k.email).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Radnik>().HasIndex(k => k.email).IsUnique();
            modelBuilder.Entity<Radnik>().Property(k => k.sifra).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Radnik>().Property(k => k.sluzbeniTel).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Radnik>().Property(k => k.privatniTel).IsRequired().HasMaxLength(15);
            


            modelBuilder.Entity<Filijala>().HasKey(k => k.PIB);
            modelBuilder.Entity<Filijala>().Property(k => k.naziv).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Filijala>().Property(k => k.sediste).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Filijala>().Property(k => k.maticniBroj).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Filijala>().Property(k => k.sifraMenadzera).IsOptional();
            modelBuilder.Entity<Filijala>().Property(k => k.racun).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Filijala>().Property(k => k.telefon).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Filijala>().Property(k => k.email).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Filijala>().Property(k => k.webAdresa).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Filijala>().HasOptional(b => b.GlavniMenadzer).WithMany(a => a.Filijalas).HasForeignKey(b => b.sifraMenadzera).WillCascadeOnDelete(false);


            modelBuilder.Entity<Hotel>().HasKey(k => k.idHotela);
            modelBuilder.Entity<Hotel>().Property(k => k.ime).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Hotel>().Property(k => k.lokacija).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Hotel>().Property(k => k.kategorija).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Hotel>().Property(k => k.email).HasMaxLength(50);
            modelBuilder.Entity<Hotel>().Property(k => k.webadresa).HasMaxLength(50);


            modelBuilder.Entity<KartePrevoza>().HasKey(k => k.idKarte);
            modelBuilder.Entity<KartePrevoza>().Property(k => k.destinacija).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<KartePrevoza>().Property(k => k.datum).IsRequired();
            modelBuilder.Entity<KartePrevoza>().Property(k => k.cena).IsRequired();
            modelBuilder.Entity<KartePrevoza>().Property(k => k.tipPrevoza).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<KartePrevoza>().HasRequired(b => b.Korisnik).WithMany(a => a.KartePrevozas).HasForeignKey(b => b.jmbgKorisnika);


            modelBuilder.Entity<Korisnik>().HasKey(k => k.jmbgKorisnika);
            modelBuilder.Entity<Korisnik>().Property(k => k.ime).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Korisnik>().Property(k => k.prezime).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Korisnik>().Property(k => k.adresa).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Korisnik>().Property(k => k.telefon).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Korisnik>().Property(k => k.email).IsRequired().HasMaxLength(50);


            modelBuilder.Entity<RezAranzmana>().HasKey(k => k.idRez);
            modelBuilder.Entity<RezAranzmana>().Property(k => k.idAranzmana).IsRequired();
            modelBuilder.Entity<RezAranzmana>().HasRequired(b => b.TurAranzmann).WithMany(a => a.RezAranzmanas).HasForeignKey(b => b.idAranzmana);
            modelBuilder.Entity<RezAranzmana>().Property(k => k.jmbgKorisnika).IsRequired();
            modelBuilder.Entity<RezAranzmana>().HasRequired(b => b.Korisnik).WithMany(a => a.RezAranzmanas).HasForeignKey(b => b.jmbgKorisnika);
            modelBuilder.Entity<RezAranzmana>().Property(k => k.datumRez).IsRequired();
            modelBuilder.Entity<RezAranzmana>().Property(k => k.brOsoba).IsRequired();
            modelBuilder.Entity<RezAranzmana>().Property(k => k.ukupnaCena).IsRequired();


            modelBuilder.Entity<RezSmestaja>().HasKey(k => k.idRez);
            modelBuilder.Entity<RezSmestaja>().Property(k => k.idHotela).IsRequired();
            modelBuilder.Entity<RezSmestaja>().HasRequired(b => b.Hotel).WithMany(a => a.RezSmestajas).HasForeignKey(b => b.idHotela);
            modelBuilder.Entity<RezSmestaja>().Property(k => k.jmbgKlijenta).IsRequired();
            modelBuilder.Entity<RezSmestaja>().HasRequired(b => b.Korisnik).WithMany(a => a.RezSmestajas).HasForeignKey(b => b.jmbgKlijenta);
            modelBuilder.Entity<RezSmestaja>().Property(k => k.datumPocetka).IsRequired();
            modelBuilder.Entity<RezSmestaja>().Property(k => k.datumZavrsetka).IsRequired();
            modelBuilder.Entity<RezSmestaja>().Property(k => k.vrstaUsluge).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<RezSmestaja>().Property(k => k.cenaUsluge).IsRequired();


            modelBuilder.Entity<TurAranzmann>().HasKey(k => k.idAranzmana);
            modelBuilder.Entity<TurAranzmann>().Property(k => k.destinacija).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<TurAranzmann>().Property(k => k.datumPocetka).IsRequired();
            modelBuilder.Entity<TurAranzmann>().Property(k => k.datumKraja).IsRequired();
            modelBuilder.Entity<TurAranzmann>().Property(k => k.cena).IsRequired();
            modelBuilder.Entity<TurAranzmann>().Property(k => k.nacinPlacanja).IsRequired().HasMaxLength(20);
         

        }
    }
}
