using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicModels
{
  
    public class Wishlist
    {
        public int Id { get; set; } 
        public int BookId { get; set; }
        public int UserId { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
