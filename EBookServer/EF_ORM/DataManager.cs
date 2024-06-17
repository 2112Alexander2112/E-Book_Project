using EBookLib01.BasicModels;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;

namespace EBookServer.EF_ORM
{
    public class DataManager : DbContext
    {
       
        public DataManager()
            : base("name=DataManager")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wishlist>()
            .HasRequired(w => w.Book)
            .WithMany()
            .HasForeignKey(w => w.BookId);

            modelBuilder.Entity<Wishlist>()
                .HasRequired(w => w.User)
                .WithMany()
                .HasForeignKey(w => w.UserId);

            modelBuilder.Entity<Book>().HasKey(e => e.Id);
          }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookInfo> BookInfos { get; set; }
        public DbSet<BookSeries> BookSeries { get; set; }
        public DbSet<BookStatistic> BookStatistics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MyLibrary> MyLibraries { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}