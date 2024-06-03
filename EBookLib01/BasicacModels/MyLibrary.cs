using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicacModels
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
