namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhishlistColleration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Wishlist_Id", "dbo.Wishlists");
            DropIndex("dbo.Books", new[] { "Wishlist_Id" });
            CreateIndex("dbo.Wishlists", "BookId");
            AddForeignKey("dbo.Wishlists", "BookId", "dbo.Books", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "Wishlist_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Wishlist_Id", c => c.Int());
            DropForeignKey("dbo.Wishlists", "BookId", "dbo.Books");
            DropIndex("dbo.Wishlists", new[] { "BookId" });
            CreateIndex("dbo.Books", "Wishlist_Id");
            AddForeignKey("dbo.Books", "Wishlist_Id", "dbo.Wishlists", "Id");
        }
    }
}
