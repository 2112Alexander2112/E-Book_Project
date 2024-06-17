namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WishlistBooks", "Wishlist_Id", "dbo.Wishlists");
            DropForeignKey("dbo.WishlistBooks", "Book_Id", "dbo.Books");
            DropIndex("dbo.WishlistBooks", new[] { "Wishlist_Id" });
            DropIndex("dbo.WishlistBooks", new[] { "Book_Id" });
            AddColumn("dbo.Books", "Wishlist_Id", c => c.Int());
            CreateIndex("dbo.Books", "Wishlist_Id");
            AddForeignKey("dbo.Books", "Wishlist_Id", "dbo.Wishlists", "Id");
            DropTable("dbo.WishlistBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WishlistBooks",
                c => new
                    {
                        Wishlist_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Wishlist_Id, t.Book_Id });
            
            DropForeignKey("dbo.Books", "Wishlist_Id", "dbo.Wishlists");
            DropIndex("dbo.Books", new[] { "Wishlist_Id" });
            DropColumn("dbo.Books", "Wishlist_Id");
            CreateIndex("dbo.WishlistBooks", "Book_Id");
            CreateIndex("dbo.WishlistBooks", "Wishlist_Id");
            AddForeignKey("dbo.WishlistBooks", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
            AddForeignKey("dbo.WishlistBooks", "Wishlist_Id", "dbo.Wishlists", "Id", cascadeDelete: true);
        }
    }
}
