namespace GymApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerTableModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "PackageId", "dbo.Packages");
            DropIndex("dbo.Customers", new[] { "PackageId" });
            AlterColumn("dbo.Customers", "PackageId", c => c.Int());
            CreateIndex("dbo.Customers", "PackageId");
            AddForeignKey("dbo.Customers", "PackageId", "dbo.Packages", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "PackageId", "dbo.Packages");
            DropIndex("dbo.Customers", new[] { "PackageId" });
            AlterColumn("dbo.Customers", "PackageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "PackageId");
            AddForeignKey("dbo.Customers", "PackageId", "dbo.Packages", "id", cascadeDelete: true);
        }
    }
}
