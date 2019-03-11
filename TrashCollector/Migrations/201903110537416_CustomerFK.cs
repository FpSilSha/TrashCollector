namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerFK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PickUps");
            AlterColumn("dbo.PickUps", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PickUps", "Id");
            CreateIndex("dbo.PickUps", "Id");
            AddForeignKey("dbo.PickUps", "Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickUps", "Id", "dbo.Customers");
            DropIndex("dbo.PickUps", new[] { "Id" });
            DropPrimaryKey("dbo.PickUps");
            AlterColumn("dbo.PickUps", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PickUps", "Id");
        }
    }
}
