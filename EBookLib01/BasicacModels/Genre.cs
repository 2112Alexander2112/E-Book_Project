using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01
{
    [Serializable]
    public class Genre
    {
        [Required]
        public int Id { get; set; }
        public string GenreName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
