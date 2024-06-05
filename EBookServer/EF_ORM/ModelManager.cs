using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EBookLib01.HelperModels.TransitModels;
using EBookLib01.BasicModels;
using System.Security.Policy;


namespace EBookServer.EF_ORM
{
    public class ModelManager : DbContext
    {

        public ModelManager()
            : base("name=ModelManager")
        {
           
        }
        // Basical models
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Achievement>  Achievements { get; set; }
        public virtual DbSet<BookInfo> BookInfos { get; set; }
        public virtual DbSet<BookSeries> BookSerieses { get; set; }
        public virtual DbSet<BookStatistic> BookStatistices { get; set; }   
        public virtual DbSet<Friend> Friends { get; set; }  
        public virtual DbSet<MyLibrary> MyLibraries { get; set; }   
        public virtual DbSet<Publisherr> Publishers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<UserAchievement> UserAchievements { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }  
        public virtual DbSet<Wishlist> Wishlists { get; set; }

        // Service models
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}

    
