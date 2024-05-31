using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;

namespace EBookLIb.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
