namespace CinemaClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        SSN = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        StartTime = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                        ScreeningId = c.Int(nullable: false),
                        SeatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Screenings", t => t.ScreeningId, cascadeDelete: true)
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ScreeningId)
                .Index(t => t.SeatId);
            
            CreateTable(
                "dbo.Screenings",
                c => new
                    {
                        ScreeningId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        StartTime = c.String(),
                        SaloonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScreeningId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Saloons", t => t.SaloonId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.SaloonId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Saloons",
                c => new
                    {
                        SaloonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MovieId = c.Int(),
                        WheelchairRamp = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SaloonId)
                .ForeignKey("dbo.Movies", t => t.MovieId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        Row = c.Int(nullable: false),
                        Location = c.Int(nullable: false),
                        IsOccupied = c.Boolean(nullable: false),
                        Saloon_SaloonId = c.Int(),
                    })
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Saloons", t => t.Saloon_SaloonId)
                .Index(t => t.Saloon_SaloonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Tickets", "ScreeningId", "dbo.Screenings");
            DropForeignKey("dbo.Seats", "Saloon_SaloonId", "dbo.Saloons");
            DropForeignKey("dbo.Screenings", "SaloonId", "dbo.Saloons");
            DropForeignKey("dbo.Saloons", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Screenings", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Seats", new[] { "Saloon_SaloonId" });
            DropIndex("dbo.Saloons", new[] { "MovieId" });
            DropIndex("dbo.Screenings", new[] { "SaloonId" });
            DropIndex("dbo.Screenings", new[] { "MovieId" });
            DropIndex("dbo.Tickets", new[] { "SeatId" });
            DropIndex("dbo.Tickets", new[] { "ScreeningId" });
            DropIndex("dbo.Tickets", new[] { "CustomerId" });
            DropTable("dbo.Seats");
            DropTable("dbo.Saloons");
            DropTable("dbo.Movies");
            DropTable("dbo.Screenings");
            DropTable("dbo.Tickets");
            DropTable("dbo.Customers");
        }
    }
}
