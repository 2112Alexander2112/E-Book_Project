using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicacModels
{
  
    public class BookStatistic
    {
        
        public int Id { get; set; }
        public float TotalRaiting { get; set; }
        public int Sells { get; set; }
        public int BookId { get; set; }
        public int InNumberOfWishLists { get; set; }

        public virtual Book Book { get; set; }
    }
}
