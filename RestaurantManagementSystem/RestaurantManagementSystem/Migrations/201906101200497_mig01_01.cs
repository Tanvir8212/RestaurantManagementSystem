namespace RestaurantManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig01_01 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodItems", "Transection_Id", "dbo.Transections");
            DropIndex("dbo.FoodItems", new[] { "Transection_Id" });
            DropColumn("dbo.FoodItems", "Transection_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodItems", "Transection_Id", c => c.Long());
            CreateIndex("dbo.FoodItems", "Transection_Id");
            AddForeignKey("dbo.FoodItems", "Transection_Id", "dbo.Transections", "Id");
        }
    }
}
