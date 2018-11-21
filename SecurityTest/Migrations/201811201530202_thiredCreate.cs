namespace SecurityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thiredCreate : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
            DropTable("dbo.MemberShipVMs");
        }
    }
}
