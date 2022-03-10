namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderItems", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "Image");
            DropColumn("dbo.OrderItems", "Price");
        }
    }
}
