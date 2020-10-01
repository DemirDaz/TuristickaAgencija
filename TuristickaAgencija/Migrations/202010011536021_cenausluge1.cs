namespace TuristickaAgencija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cenausluge1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotels", "kategorija", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotels", "kategorija", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
