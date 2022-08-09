namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Presentations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IsPresentation = c.Boolean(nullable: false),
                    MovieId = c.Int(nullable: false),
                    SaloonId = c.Byte(nullable: false),
                    SessionId = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Saloons", t => t.SaloonId, cascadeDelete: true)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.SaloonId)
                .Index(t => t.SessionId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Presentations", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.Presentations", "SaloonId", "dbo.Saloons");
            DropForeignKey("dbo.Presentations", "MovieId", "dbo.Movies");
            DropIndex("dbo.Presentations", new[] { "SessionId" });
            DropIndex("dbo.Presentations", new[] { "SaloonId" });
            DropIndex("dbo.Presentations", new[] { "MovieId" });
            DropTable("dbo.Presentations");
        }
    }
}
