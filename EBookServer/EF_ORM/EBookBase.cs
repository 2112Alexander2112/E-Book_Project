using EBookLib01.BasicacModels;
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
    }

}