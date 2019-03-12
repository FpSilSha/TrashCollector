namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPickUpBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PickUps", "PickupCompleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PickUps", "PickupCompleted");
        }
    }
}
