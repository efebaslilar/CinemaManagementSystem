namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SellTickets", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SellTickets", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.SellTickets", "SaloonId", "dbo.Saloons");
            DropForeignKey("dbo.SellTickets", "SessionId", "dbo.Sessions");
            DropIndex("dbo.SellTickets", new[] { "MovieId" });
            DropIndex("dbo.SellTickets", new[] { "CustomerId" });
            DropIndex("dbo.SellTickets", new[] { "SessionId" });
            DropIndex("dbo.SellTickets", new[] { "SaloonId" });
            AddColumn("dbo.SellTickets", "PresentationId", c => c.Int(nullable: false));
            AddColumn("dbo.SellTickets", "CustomerNameSurname", c => c.String());
            CreateIndex("dbo.SellTickets", "PresentationId");
            AddForeignKey("dbo.SellTickets", "PresentationId", "dbo.Presentations", "Id", cascadeDelete: true);
            DropColumn("dbo.SellTickets", "MovieId");
            DropColumn("dbo.SellTickets", "CustomerId");
            DropColumn("dbo.SellTickets", "SessionId");
            DropColumn("dbo.SellTickets", "SaloonId");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SellTickets", "SaloonId", c => c.Byte(nullable: false));
            AddColumn("dbo.SellTickets", "SessionId", c => c.Byte(nullable: false));
            AddColumn("dbo.SellTickets", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.SellTickets", "MovieId", c => c.Int(nullable: false));
            DropForeignKey("dbo.SellTickets", "PresentationId", "dbo.Presentations");
            DropIndex("dbo.SellTickets", new[] { "PresentationId" });
            DropColumn("dbo.SellTickets", "CustomerNameSurname");
            DropColumn("dbo.SellTickets", "PresentationId");
            CreateIndex("dbo.SellTickets", "SaloonId");
            CreateIndex("dbo.SellTickets", "SessionId");
            CreateIndex("dbo.SellTickets", "CustomerId");
            CreateIndex("dbo.SellTickets", "MovieId");
            AddForeignKey("dbo.SellTickets", "SessionId", "dbo.Sessions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SellTickets", "SaloonId", "dbo.Saloons", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SellTickets", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SellTickets", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
