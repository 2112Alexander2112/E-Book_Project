using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;
using EBookLib01.BasicModels;

namespace EBookLib01.BasicModels
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
