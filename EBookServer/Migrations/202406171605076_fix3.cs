namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Wishlists", "BookId", "dbo.Books");
            DropForeignKey("dbo.MyLibraries", "UserId", "dbo.Users");
            DropForeignKey("dbo.Books", "MyLibrary_UserId", "dbo.MyLibraries");
            DropIndex("dbo.Wishlists", new[] { "BookId" });
            RenameColumn(table: "dbo.Books", name: "MyLibrary_UserId", newName: "MyLibrary_Id");
            RenameIndex(table: "dbo.Books", name: "IX_MyLibrary_UserId", newName: "IX_MyLibrary_Id");
            DropPrimaryKey("dbo.MyLibraries");
            CreateTable(
                "dbo.WishlistBooks",
                c => new
                    {
                        Wishlist_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Wishlist_Id, t.Book_Id })
                .ForeignKey("dbo.Wishlists", t => t.Wishlist_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Wishlist_Id)
                .Index(t => t.Book_Id);
            
            AddColumn("dbo.MyLibraries", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MyLibraries", "Id");
            AddForeignKey("dbo.MyLibraries", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "MyLibrary_Id", "dbo.MyLibraries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "MyLibrary_Id", "dbo.MyLibraries");
            DropForeignKey("dbo.MyLibraries", "UserId", "dbo.Users");
            DropForeignKey("dbo.WishlistBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.WishlistBooks", "Wishlist_Id", "dbo.Wishlists");
            DropIndex("dbo.WishlistBooks", new[] { "Book_Id" });
            DropIndex("dbo.WishlistBooks", new[] { "Wishlist_Id" });
            DropPrimaryKey("dbo.MyLibraries");
            DropColumn("dbo.MyLibraries", "Id");
            DropTable("dbo.WishlistBooks");
            AddPrimaryKey("dbo.MyLibraries", "UserId");
            RenameIndex(table: "dbo.Books", name: "IX_MyLibrary_Id", newName: "IX_MyLibrary_UserId");
            RenameColumn(table: "dbo.Books", name: "MyLibrary_Id", newName: "MyLibrary_UserId");
            CreateIndex("dbo.Wishlists", "BookId");
            AddForeignKey("dbo.Books", "MyLibrary_UserId", "dbo.MyLibraries", "UserId");
            AddForeignKey("dbo.MyLibraries", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Wishlists", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
