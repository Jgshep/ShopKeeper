namespace ShopKeeper.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopItems",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShopItems");
        }
    }
}
