using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicacModels
{

    public class Author
    {
            [Required]
            public int Id { get; set; }
            public string AuthorName { get; set; }
            public float Rate { get; set; }
            public virtual List<Book> Books { get; set; }
    }
}
