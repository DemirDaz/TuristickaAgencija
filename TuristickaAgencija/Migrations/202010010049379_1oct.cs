namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1oct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KartePrevozas", "jmbgKorisnika", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.KartePrevozas", "jmbgKorisnika");
            AddForeignKey("dbo.KartePrevozas", "jmbgKorisnika", "dbo.Korisniks", "jmbgKorisnika", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KartePrevozas", "jmbgKorisnika", "dbo.Korisniks");
            DropIndex("dbo.KartePrevozas", new[] { "jmbgKorisnika" });
            DropColumn("dbo.KartePrevozas", "jmbgKorisnika");
        }
    }
}
