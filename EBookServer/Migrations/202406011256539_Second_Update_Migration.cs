namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second_Update_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        Rate = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        BookName = c.String(),
                        AlterName = c.String(),
                        Published = c.DateTime(nullable: false),
                        PublisherId = c.Int(nullable: false),
                        BookInfoId = c.Int(nullable: false),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.CategoryId)
                .Index(t => t.AuthorId)
                .Index(t => t.PublisherId)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.BookInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        BookName = c.String(),
                        AlterName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserLogin = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        RoleId = c.Int(nullable: false),
                        PublicsherId = c.Int(nullable: false),
                        Publisher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.Publisher_Id);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.MyLibraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Wishlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                        ImagePath = c.String(),
                        BirtDay = c.DateTime(nullable: false),
                        Gender = c.String(),
                        About = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "BookId", "dbo.Books");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.Wishlists", "UserId", "dbo.Users");
            DropForeignKey("dbo.Wishlists", "BookId", "dbo.Books");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.MyLibraries", "UserId", "dbo.Users");
            DropForeignKey("dbo.MyLibraries", "BookId", "dbo.Books");
            DropForeignKey("dbo.Friends", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Genres", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Books", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookInfoes", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.UserInformations", new[] { "UserId" });
            DropIndex("dbo.Transactions", new[] { "BookId" });
            DropIndex("dbo.Wishlists", new[] { "UserId" });
            DropIndex("dbo.Wishlists", new[] { "BookId" });
            DropIndex("dbo.MyLibraries", new[] { "UserId" });
            DropIndex("dbo.MyLibraries", new[] { "BookId" });
            DropIndex("dbo.Friends", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Publisher_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Reviews", new[] { "BookId" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Genres", new[] { "CategoryId" });
            DropIndex("dbo.BookInfoes", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropTable("dbo.UserInformations");
            DropTable("dbo.Transactions");
            DropTable("dbo.Wishlists");
            DropTable("dbo.Roles");
            DropTable("dbo.MyLibraries");
            DropTable("dbo.Friends");
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Categories");
            DropTable("dbo.BookInfoes");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
