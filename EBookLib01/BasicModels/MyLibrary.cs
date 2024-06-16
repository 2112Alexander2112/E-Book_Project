using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBookLib01.BasicModels
{

    public class MyLibrary
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public int BookId { get; set; }

        public virtual User User { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
