using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLIb.Models
{
    [Serializable]
    public class Book
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        public string AlterName { get; set; }
        public DateTime Published { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
    }
}
