namespace ShopKeeper.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIntIdToDataModel_Attempt1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ShopItems", "Name", c => c.String());
            AddColumn("dbo.ShopItems", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ShopItems", "ID");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShopItems", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.ShopItems", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ShopItems", "Name");
        }
    }
}
