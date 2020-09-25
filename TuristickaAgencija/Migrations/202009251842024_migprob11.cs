namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migprob11 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Filijalas", new[] { "sifraMenadzera" });
            AlterColumn("dbo.Filijalas", "sifraMenadzera", c => c.String(maxLength: 128));
            CreateIndex("dbo.Filijalas", "sifraMenadzera");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Filijalas", new[] { "sifraMenadzera" });
            AlterColumn("dbo.Filijalas", "sifraMenadzera", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Filijalas", "sifraMenadzera");
        }
    }
}
