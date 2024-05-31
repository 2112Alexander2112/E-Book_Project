using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace EBookLib01
{
    [Serializable]
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Genre> Genres { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
