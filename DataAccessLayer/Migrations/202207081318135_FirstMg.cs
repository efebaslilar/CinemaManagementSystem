namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        Director = c.String(),
                        Duration = c.Int(nullable: false),
                        MovieTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieTypes", t => t.MovieTypeId, cascadeDelete: true)
                .Index(t => t.MovieTypeId);
            
            CreateTable(
                "dbo.MovieTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        MovieTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Saloons",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        SaloonNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SellTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        SessionId = c.Byte(nullable: false),
                        SaloonId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Saloons", t => t.SaloonId, cascadeDelete: true)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CustomerId)
                .Index(t => t.SessionId)
                .Index(t => t.SaloonId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        MovieSession = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellTickets", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.SellTickets", "SaloonId", "dbo.Saloons");
            DropForeignKey("dbo.SellTickets", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.SellTickets", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes");
            DropIndex("dbo.SellTickets", new[] { "SaloonId" });
            DropIndex("dbo.SellTickets", new[] { "SessionId" });
            DropIndex("dbo.SellTickets", new[] { "CustomerId" });
            DropIndex("dbo.SellTickets", new[] { "MovieId" });
            DropIndex("dbo.Movies", new[] { "MovieTypeId" });
            DropTable("dbo.Sessions");
            DropTable("dbo.SellTickets");
            DropTable("dbo.Saloons");
            DropTable("dbo.MovieTypes");
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}
