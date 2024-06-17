namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoBookInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "BookInfoId", "dbo.BookInfoes");
            DropIndex("dbo.Books", new[] { "BookInfoId" });
            RenameColumn(table: "dbo.Books", name: "BookInfoId", newName: "BookInfo_Id");
            AlterColumn("dbo.Books", "BookInfo_Id", c => c.Int());
            CreateIndex("dbo.Books", "BookInfo_Id");
            AddForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookInfo_Id", "dbo.BookInfoes");
            DropIndex("dbo.Books", new[] { "BookInfo_Id" });
            AlterColumn("dbo.Books", "BookInfo_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Books", name: "BookInfo_Id", newName: "BookInfoId");
            CreateIndex("dbo.Books", "BookInfoId");
            AddForeignKey("dbo.Books", "BookInfoId", "dbo.BookInfoes", "Id", cascadeDelete: true);
        }
    }
}
