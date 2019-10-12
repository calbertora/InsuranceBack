namespace InsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig_ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolicyTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descriptio = c.String(),
                        Insurance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Insurance", t => t.Insurance_Id)
                .Index(t => t.Insurance_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PolicyTypes", "Insurance_Id", "dbo.Insurance");
            DropIndex("dbo.PolicyTypes", new[] { "Insurance_Id" });
            DropTable("dbo.PolicyTypes");
        }
    }
}
