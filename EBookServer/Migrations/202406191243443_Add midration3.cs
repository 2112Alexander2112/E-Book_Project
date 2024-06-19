namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmidration3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "MyLibrary_Id", "dbo.MyLibraries");
            DropIndex("dbo.Books", new[] { "MyLibrary_Id" });
            CreateIndex("dbo.MyLibraries", "BookId");
            AddForeignKey("dbo.MyLibraries", "BookId", "dbo.Books", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "MyLibrary_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "MyLibrary_Id", c => c.Int());
            DropForeignKey("dbo.MyLibraries", "BookId", "dbo.Books");
            DropIndex("dbo.MyLibraries", new[] { "BookId" });
            CreateIndex("dbo.Books", "MyLibrary_Id");
            AddForeignKey("dbo.Books", "MyLibrary_Id", "dbo.MyLibraries", "Id");
        }
    }
}
