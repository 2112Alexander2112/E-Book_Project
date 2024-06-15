using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicModels
{
   
    public class Category
    {
        [Required]
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
