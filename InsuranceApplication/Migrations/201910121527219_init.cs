namespace InsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Occupation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Insurance", "User_ID", c => c.Int());
            CreateIndex("dbo.Insurance", "User_ID");
            AddForeignKey("dbo.Insurance", "User_ID", "dbo.User", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Insurance", "User_ID", "dbo.User");
            DropIndex("dbo.Insurance", new[] { "User_ID" });
            DropColumn("dbo.Insurance", "User_ID");
            DropTable("dbo.User");
        }
    }
}
