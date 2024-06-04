namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthFixed_Migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookInfoes", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookInfoes", new[] { "Book_Id" });
            DropColumn("dbo.BookInfoes", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookInfoes", "Book_Id", c => c.Int());
            CreateIndex("dbo.BookInfoes", "Book_Id");
            AddForeignKey("dbo.BookInfoes", "Book_Id", "dbo.Books", "Id");
        }
    }
}
