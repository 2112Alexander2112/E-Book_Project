using System;
using System.Data.Entity;
using System.Linq;

namespace EBookServer
{
    public class EBookDatabase : DbContext
    {
        public EBookDatabase()
            : base("name=EBookDatabase")
        {
        }
    }
}