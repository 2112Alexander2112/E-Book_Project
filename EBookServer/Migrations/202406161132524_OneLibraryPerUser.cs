namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneLibraryPerUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MyLibraries", "BookId", "dbo.Books");
            DropForeignKey("dbo.MyLibraries", "UserId", "dbo.Users");
            DropIndex("dbo.MyLibraries", new[] { "BookId" });
            DropPrimaryKey("dbo.MyLibraries");
            AddColumn("dbo.Books", "MyLibrary_UserId", c => c.Int());
            AddPrimaryKey("dbo.MyLibraries", "UserId");
            CreateIndex("dbo.Books", "MyLibrary_UserId");
            AddForeignKey("dbo.Books", "MyLibrary_UserId", "dbo.MyLibraries", "UserId");
            AddForeignKey("dbo.MyLibraries", "UserId", "dbo.Users", "Id");
            DropColumn("dbo.MyLibraries", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyLibraries", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.MyLibraries", "UserId", "dbo.Users");
            DropForeignKey("dbo.Books", "MyLibrary_UserId", "dbo.MyLibraries");
            DropIndex("dbo.Books", new[] { "MyLibrary_UserId" });
            DropPrimaryKey("dbo.MyLibraries");
            DropColumn("dbo.Books", "MyLibrary_UserId");
            AddPrimaryKey("dbo.MyLibraries", "Id");
            CreateIndex("dbo.MyLibraries", "BookId");
            AddForeignKey("dbo.MyLibraries", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MyLibraries", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
