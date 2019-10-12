namespace InsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Insurance", "CoveragePercentage", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Insurance", "CoveragePercentage");
        }
    }
}
