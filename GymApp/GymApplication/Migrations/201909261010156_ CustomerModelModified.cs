namespace GymApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModelModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PackageEntryQuantity", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PackageEntryQuantity");
        }
    }
}
