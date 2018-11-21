namespace SecurityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.userRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserRole = c.String(nullable: false),
                        userID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.users", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
            DropTable("dbo.MemberShipVMs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MemberShipVMs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.userRoles", "userID", "dbo.users");
            DropIndex("dbo.userRoles", new[] { "userID" });
            DropTable("dbo.userRoles");
        }
    }
}
