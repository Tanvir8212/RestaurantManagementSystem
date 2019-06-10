namespace RestaurantManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PromoCode = c.String(),
                        Name = c.String(),
                        DiscountPersentage = c.Double(nullable: false),
                        DiscountAmount = c.Double(nullable: false),
                        Description = c.String(),
                        Validity = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        Transection_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodCategories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Transections", t => t.Transection_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.Transection_Id);
            
            CreateTable(
                "dbo.Transections",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Discount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Discounts", t => t.Discount_Id)
                .Index(t => t.Discount_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Password = c.String(),
                        TypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "TypeId", "dbo.UserTypes");
            DropForeignKey("dbo.FoodItems", "Transection_Id", "dbo.Transections");
            DropForeignKey("dbo.Transections", "Discount_Id", "dbo.Discounts");
            DropForeignKey("dbo.FoodItems", "CategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Users", new[] { "TypeId" });
            DropIndex("dbo.Transections", new[] { "Discount_Id" });
            DropIndex("dbo.FoodItems", new[] { "Transection_Id" });
            DropIndex("dbo.FoodItems", new[] { "CategoryId" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
            DropTable("dbo.Transections");
            DropTable("dbo.FoodItems");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Discounts");
        }
    }
}
