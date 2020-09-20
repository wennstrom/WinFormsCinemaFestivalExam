namespace CinemaClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterSeats : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Seats", "IsOccupied");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seats", "IsOccupied", c => c.Boolean(nullable: false));
        }
    }
}
