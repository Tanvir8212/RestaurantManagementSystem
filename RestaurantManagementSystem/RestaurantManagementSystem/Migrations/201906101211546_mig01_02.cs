namespace RestaurantManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig01_02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransectionSubModels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FoodItemId = c.Int(nullable: false),
                        FoodItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        TransectionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transections", t => t.TransectionId, cascadeDelete: true)
                .Index(t => t.TransectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransectionSubModels", "TransectionId", "dbo.Transections");
            DropIndex("dbo.TransectionSubModels", new[] { "TransectionId" });
            DropTable("dbo.TransectionSubModels");
        }
    }
}
