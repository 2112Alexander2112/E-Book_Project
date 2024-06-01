namespace EBookServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third_Update_Database_Migration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publishers", newName: "Publisherrs");
            CreateTable(
                "dbo.Achievements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AchievementName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAchievements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AchievementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Achievements", t => t.AchievementId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AchievementId);
            
            CreateTable(
                "dbo.BookSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        SeriesName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.BookStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalRaiting = c.Single(nullable: false),
                        Sells = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        InNumberOfWishLists = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Wallets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wallets", "UserId", "dbo.Users");
            DropForeignKey("dbo.BookStatistics", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookSeries", "BookId", "dbo.Books");
            DropForeignKey("dbo.UserAchievements", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserAchievements", "AchievementId", "dbo.Achievements");
            DropIndex("dbo.Wallets", new[] { "UserId" });
            DropIndex("dbo.BookStatistics", new[] { "BookId" });
            DropIndex("dbo.BookSeries", new[] { "BookId" });
            DropIndex("dbo.UserAchievements", new[] { "AchievementId" });
            DropIndex("dbo.UserAchievements", new[] { "UserId" });
            DropTable("dbo.Wallets");
            DropTable("dbo.BookStatistics");
            DropTable("dbo.BookSeries");
            DropTable("dbo.UserAchievements");
            DropTable("dbo.Achievements");
            RenameTable(name: "dbo.Publisherrs", newName: "Publishers");
        }
    }
}
