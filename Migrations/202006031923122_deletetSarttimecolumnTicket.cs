namespace CinemaClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetSarttimecolumnTicket : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "StartTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "StartTime", c => c.String());
        }
    }
}
