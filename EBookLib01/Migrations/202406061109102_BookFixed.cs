namespace EBookLib01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookInfoes", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes");
            DropIndex("dbo.Books", new[] { "BookInfo_Id" });
            DropIndex("dbo.BookInfoes", new[] { "BookId" });
            AddColumn("dbo.Books", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Books", "IconPath", c => c.String());
            DropColumn("dbo.Books", "BookInfo_Id");
            DropColumn("dbo.BookInfoes", "BookId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookInfoes", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "BookInfo_Id", c => c.Int());
            DropColumn("dbo.Books", "IconPath");
            DropColumn("dbo.Books", "Price");
            CreateIndex("dbo.BookInfoes", "BookId");
            CreateIndex("dbo.Books", "BookInfo_Id");
            AddForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes", "Id");
            AddForeignKey("dbo.BookInfoes", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
