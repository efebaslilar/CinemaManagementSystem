namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Saloons", "SeatNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Saloons", "SeatNo");
        }
    }
}
