using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using EBookLib01;

namespace EBookServer.EF_ORM
{
    public class ModelManager : DbContext
    {

        public ModelManager()
            : base("name=ModelManager")
        {}
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }

}

    
