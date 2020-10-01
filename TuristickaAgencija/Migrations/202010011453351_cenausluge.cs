namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cenausluge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RezSmestajas", "cenaUsluge", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RezSmestajas", "cenaUsluge");
        }
    }
}
