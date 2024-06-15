using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicModels
{
    
    public class Review
    {
        public int Id { get; set; } 
        public int UserId {  get; set; }
        public int BookId { get; set; } 
        public int Rate { get; set; }
        public string Comment { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }  
    }
}
