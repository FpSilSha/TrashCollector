namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProperKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PickUps", "Id", "dbo.Customers");
            DropIndex("dbo.PickUps", new[] { "Id" });
            DropPrimaryKey("dbo.PickUps");
            AddColumn("dbo.Customers", "ApplicationUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Employees", "ApplicationUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.PickUps", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.PickUps", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PickUps", "Id");
            CreateIndex("dbo.Customers", "ApplicationUserId");
            CreateIndex("dbo.Employees", "ApplicationUserId");
            CreateIndex("dbo.PickUps", "CustomerId");
            AddForeignKey("dbo.Customers", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Employees", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PickUps", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickUps", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.PickUps", new[] { "CustomerId" });
            DropIndex("dbo.Employees", new[] { "ApplicationUserId" });
            DropIndex("dbo.Customers", new[] { "ApplicationUserId" });
            DropPrimaryKey("dbo.PickUps");
            AlterColumn("dbo.PickUps", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.PickUps", "CustomerId");
            DropColumn("dbo.Employees", "ApplicationUserId");
            DropColumn("dbo.Customers", "ApplicationUserId");
            AddPrimaryKey("dbo.PickUps", "Id");
            CreateIndex("dbo.PickUps", "Id");
            AddForeignKey("dbo.PickUps", "Id", "dbo.Customers", "Id");
        }
    }
}
