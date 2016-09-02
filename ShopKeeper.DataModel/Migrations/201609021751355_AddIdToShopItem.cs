namespace ShopKeeper.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdToShopItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShopItems", "ID", c => c.Guid(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShopItems", "ID");
        }
    }
}
