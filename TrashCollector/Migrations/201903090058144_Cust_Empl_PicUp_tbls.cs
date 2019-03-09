namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cust_Empl_PicUp_tbls : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        Street_Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmployeeNumber = c.Int(nullable: false),
                        WorkingZip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickUps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PickUpDay = c.String(),
                        ExtraDay = c.String(),
                        SuspendStart = c.DateTime(),
                        SuspendEnd = c.DateTime(),
                        CurrentCharges = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PickUps");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
