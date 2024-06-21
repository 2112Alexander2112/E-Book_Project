namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDBSova : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Friends", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Friends", "User_Id", "dbo.Users");
            DropIndex("dbo.Friends", new[] { "UserId" });
            DropIndex("dbo.Friends", new[] { "User_Id" });
            DropIndex("dbo.Friends", new[] { "User_Id1" });
            DropColumn("dbo.Friends", "UserId");
            RenameColumn(table: "dbo.Friends", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Friends", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Friends", "UserId");
            AddForeignKey("dbo.Friends", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Friends", "User_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Friends", "User_Id1", c => c.Int());
            DropForeignKey("dbo.Friends", "UserId", "dbo.Users");
            DropIndex("dbo.Friends", new[] { "UserId" });
            AlterColumn("dbo.Friends", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Friends", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Friends", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Friends", "User_Id1");
            CreateIndex("dbo.Friends", "User_Id");
            CreateIndex("dbo.Friends", "UserId");
            AddForeignKey("dbo.Friends", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Friends", "User_Id1", "dbo.Users", "Id");
        }
    }
}
