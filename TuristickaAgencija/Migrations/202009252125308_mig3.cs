namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KartePrevozaRepositories", newName: "KartePrevozas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.KartePrevozas", newName: "KartePrevozaRepositories");
        }
    }
}
