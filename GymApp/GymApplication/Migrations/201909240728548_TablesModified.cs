namespace GymApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Packages", "payment_id", "dbo.Payments");
            DropIndex("dbo.Packages", new[] { "payment_id" });
            AddColumn("dbo.Customers", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Payments", "PackageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "PackageId");
            AddForeignKey("dbo.Payments", "PackageId", "dbo.Packages", "id", cascadeDelete: false);
            DropColumn("dbo.Packages", "payment_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Packages", "payment_id", c => c.Int());
            DropForeignKey("dbo.Payments", "PackageId", "dbo.Packages");
            DropIndex("dbo.Payments", new[] { "PackageId" });
            DropColumn("dbo.Payments", "PackageId");
            DropColumn("dbo.Customers", "Balance");
            CreateIndex("dbo.Packages", "payment_id");
            AddForeignKey("dbo.Packages", "payment_id", "dbo.Payments", "id");
        }
    }
}
