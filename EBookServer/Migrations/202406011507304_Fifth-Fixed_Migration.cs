namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthFixed_Migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookInfoes", "BookId", "dbo.Books");
            DropIndex("dbo.BookInfoes", new[] { "BookId" });
            AddColumn("dbo.Books", "Image", c => c.String());
            DropColumn("dbo.BookInfoes", "BookId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookInfoes", "BookId", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Image");
            CreateIndex("dbo.BookInfoes", "BookId");
            AddForeignKey("dbo.BookInfoes", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
