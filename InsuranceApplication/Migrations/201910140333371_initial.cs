namespace InsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        InitialDate = c.DateTime(nullable: false),
                        Coverage = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        TypeOfRisk = c.Int(nullable: false),
                        CoveragePercentage = c.Int(nullable: false),
                        PolicyTypes = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Occupation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Insurance", "User_ID", "dbo.User");
            DropIndex("dbo.Insurance", new[] { "User_ID" });
            DropTable("dbo.User");
            DropTable("dbo.Insurance");
        }
    }
}
