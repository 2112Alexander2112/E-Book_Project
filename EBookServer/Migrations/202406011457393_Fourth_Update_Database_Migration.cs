namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourth_Update_Database_Migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes");
            DropForeignKey("dbo.Books", "Book_Id", "dbo.Books");
            DropIndex("dbo.Books", new[] { "BookInfo_Id" });
            DropIndex("dbo.Books", new[] { "Book_Id" });
            DropColumn("dbo.Books", "BookInfo_Id");
            DropColumn("dbo.Books", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Book_Id", c => c.Int());
            AddColumn("dbo.Books", "BookInfo_Id", c => c.Int());
            CreateIndex("dbo.Books", "Book_Id");
            CreateIndex("dbo.Books", "BookInfo_Id");
            AddForeignKey("dbo.Books", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes", "Id");
        }
    }
}
