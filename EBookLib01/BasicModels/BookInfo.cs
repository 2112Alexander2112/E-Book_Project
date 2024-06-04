using System;
using System.Collections.Generic;

namespace EBookLib01.BasicModels
{
    [Serializable]
    public class BookInfo
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime CreateDate { get; set; }
        public string BookName { get; set; }
        public string AlterName { get; set; }

        public virtual List<Book> Books { get; set; }
        public virtual Book Book { get; set; }
    }
}
