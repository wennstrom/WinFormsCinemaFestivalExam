namespace CinemaClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wheelchair : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Wheelchair", c => c.Boolean(nullable: false));
            AddColumn("dbo.Seats", "OptionForWheelchair", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Seats", "OptionForWheelchair");
            DropColumn("dbo.Tickets", "Wheelchair");
        }
    }
}
