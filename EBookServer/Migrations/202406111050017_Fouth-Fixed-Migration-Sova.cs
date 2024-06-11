namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FouthFixedMigrationSova : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookInfoes", "BookInfo_Id", c => c.Int());
            CreateIndex("dbo.BookInfoes", "BookInfo_Id");
            AddForeignKey("dbo.BookInfoes", "BookInfo_Id", "dbo.BookInfoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookInfoes", "BookInfo_Id", "dbo.BookInfoes");
            DropIndex("dbo.BookInfoes", new[] { "BookInfo_Id" });
            DropColumn("dbo.BookInfoes", "BookInfo_Id");
        }
    }
}
