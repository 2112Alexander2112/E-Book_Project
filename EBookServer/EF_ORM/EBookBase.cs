using EBookLIb.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace EBookServer.EF_ORM
{
    public class EBookBase : DbContext
    {
        public EBookBase()
            : base("name=EBookBase")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

}