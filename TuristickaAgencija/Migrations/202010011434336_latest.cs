namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RezSmestajas", "jmbgKlijenta", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.RezSmestajas", "jmbgKlijenta");
            AddForeignKey("dbo.RezSmestajas", "jmbgKlijenta", "dbo.Korisniks", "jmbgKorisnika", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RezSmestajas", "jmbgKlijenta", "dbo.Korisniks");
            DropIndex("dbo.RezSmestajas", new[] { "jmbgKlijenta" });
            DropColumn("dbo.RezSmestajas", "jmbgKlijenta");
        }
    }
}
