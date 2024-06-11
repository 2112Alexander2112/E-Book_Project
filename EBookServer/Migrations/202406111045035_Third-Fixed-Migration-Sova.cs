namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdFixedMigrationSova : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Book_Id", "dbo.Books");
            DropIndex("dbo.Books", new[] { "Book_Id" });
            DropColumn("dbo.Books", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Book_Id", c => c.Int());
            CreateIndex("dbo.Books", "Book_Id");
            AddForeignKey("dbo.Books", "Book_Id", "dbo.Books", "Id");
        }
    }
}
