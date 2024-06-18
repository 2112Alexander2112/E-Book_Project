namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoBookInfoCheck : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes");
            DropIndex("dbo.Books", new[] { "BookInfo_Id" });
            DropColumn("dbo.Books", "BookInfo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "BookInfo_Id", c => c.Int());
            CreateIndex("dbo.Books", "BookInfo_Id");
            AddForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes", "Id");
        }
    }
}
