namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migprob1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filijalas",
                c => new
                    {
                        PIB = c.Int(nullable: false, identity: true),
                        naziv = c.String(nullable: false, maxLength: 20),
                        sediste = c.String(nullable: false, maxLength: 20),
                        sifraMenadzera = c.String(nullable: false, maxLength: 128),
                        maticniBroj = c.String(nullable: false, maxLength: 20),
                        racun = c.String(nullable: false, maxLength: 25),
                        telefon = c.String(nullable: false, maxLength: 15),
                        email = c.String(nullable: false, maxLength: 50),
                        webAdresa = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PIB)
                .ForeignKey("dbo.Radniks", t => t.sifraMenadzera)
                .Index(t => t.sifraMenadzera);
            
            CreateTable(
                "dbo.Radniks",
                c => new
                    {
                        jmbgRadnika = c.String(nullable: false, maxLength: 128),
                        ime = c.String(nullable: false, maxLength: 20),
                        imeRoditelja = c.String(nullable: false, maxLength: 20),
                        prezime = c.String(nullable: false, maxLength: 30),
                        datumRodjenja = c.DateTime(nullable: false),
                        strucnaSprema = c.String(nullable: false, maxLength: 30),
                        pozicija = c.String(nullable: false, maxLength: 30),
                        sifraFilijale = c.Int(nullable: false),
                        adresa = c.String(nullable: false, maxLength: 30),
                        email = c.String(nullable: false, maxLength: 50),
                        sifra = c.String(nullable: false, maxLength: 30),
                        sluzbeniTel = c.String(nullable: false, maxLength: 15),
                        privatniTel = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.jmbgRadnika)
                .ForeignKey("dbo.Filijalas", t => t.sifraFilijale)
                .Index(t => t.sifraFilijale)
                .Index(t => t.email, unique: true);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        idHotela = c.Int(nullable: false, identity: true),
                        ime = c.String(nullable: false, maxLength: 20),
                        lokacija = c.String(nullable: false, maxLength: 25),
                        kategorija = c.String(nullable: false, maxLength: 15),
                        email = c.String(maxLength: 50),
                        webadresa = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idHotela);
            
            CreateTable(
                "dbo.RezSmestajas",
                c => new
                    {
                        idRez = c.Int(nullable: false, identity: true),
                        idHotela = c.Int(nullable: false),
                        datumPocetka = c.DateTime(nullable: false),
                        datumZavrsetka = c.DateTime(nullable: false),
                        vrstaUsluge = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.idRez)
                .ForeignKey("dbo.Hotels", t => t.idHotela, cascadeDelete: true)
                .Index(t => t.idHotela);
            
            CreateTable(
                "dbo.KartePrevozaRepositories",
                c => new
                    {
                        idKarte = c.Int(nullable: false, identity: true),
                        destinacija = c.String(nullable: false, maxLength: 50),
                        datum = c.DateTime(nullable: false),
                        cena = c.Single(nullable: false),
                        tipPrevoza = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.idKarte);
            
            CreateTable(
                "dbo.Korisniks",
                c => new
                    {
                        jmbgKorisnika = c.String(nullable: false, maxLength: 128),
                        ime = c.String(nullable: false, maxLength: 20),
                        prezime = c.String(nullable: false, maxLength: 30),
                        adresa = c.String(nullable: false, maxLength: 50),
                        telefon = c.String(nullable: false, maxLength: 15),
                        email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.jmbgKorisnika);
            
            CreateTable(
                "dbo.RezAranzmanas",
                c => new
                    {
                        idRez = c.Int(nullable: false, identity: true),
                        idAranzmana = c.Int(nullable: false),
                        jmbgKorisnika = c.String(nullable: false, maxLength: 128),
                        datumRez = c.DateTime(nullable: false),
                        brOsoba = c.Int(nullable: false),
                        UkupnaCena = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idRez)
                .ForeignKey("dbo.Korisniks", t => t.jmbgKorisnika, cascadeDelete: true)
                .ForeignKey("dbo.TurAranzmanns", t => t.idAranzmana, cascadeDelete: true)
                .Index(t => t.idAranzmana)
                .Index(t => t.jmbgKorisnika);
            
            CreateTable(
                "dbo.TurAranzmanns",
                c => new
                    {
                        idAranzmana = c.Int(nullable: false, identity: true),
                        destinacija = c.String(nullable: false, maxLength: 30),
                        datumPocetka = c.DateTime(nullable: false),
                        datumKraja = c.DateTime(nullable: false),
                        cena = c.Single(nullable: false),
                        nacinPlacanja = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.idAranzmana);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RezAranzmanas", "idAranzmana", "dbo.TurAranzmanns");
            DropForeignKey("dbo.RezAranzmanas", "jmbgKorisnika", "dbo.Korisniks");
            DropForeignKey("dbo.RezSmestajas", "idHotela", "dbo.Hotels");
            DropForeignKey("dbo.Filijalas", "sifraMenadzera", "dbo.Radniks");
            DropForeignKey("dbo.Radniks", "sifraFilijale", "dbo.Filijalas");
            DropIndex("dbo.RezAranzmanas", new[] { "jmbgKorisnika" });
            DropIndex("dbo.RezAranzmanas", new[] { "idAranzmana" });
            DropIndex("dbo.RezSmestajas", new[] { "idHotela" });
            DropIndex("dbo.Radniks", new[] { "email" });
            DropIndex("dbo.Radniks", new[] { "sifraFilijale" });
            DropIndex("dbo.Filijalas", new[] { "sifraMenadzera" });
            DropTable("dbo.TurAranzmanns");
            DropTable("dbo.RezAranzmanas");
            DropTable("dbo.Korisniks");
            DropTable("dbo.KartePrevozaRepositories");
            DropTable("dbo.RezSmestajas");
            DropTable("dbo.Hotels");
            DropTable("dbo.Radniks");
            DropTable("dbo.Filijalas");
        }
    }
}
