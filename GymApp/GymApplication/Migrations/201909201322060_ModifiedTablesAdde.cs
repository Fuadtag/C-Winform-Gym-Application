namespace GymApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedTablesAdde : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "PackageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "PackageId", c => c.Int(nullable: false));
        }
    }
}
