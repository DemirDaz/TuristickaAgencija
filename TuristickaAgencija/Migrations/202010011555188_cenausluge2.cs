namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cenausluge2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RezSmestajas", "vrstaUsluge", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RezSmestajas", "vrstaUsluge", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
