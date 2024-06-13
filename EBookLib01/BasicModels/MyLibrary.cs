using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicModels
{
    
    public class MyLibrary
    {
        public int Id { get; set; } 
        public int BookId { get; set; } 
        public int UserId { get; set; } 

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }  

    }
}
