using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{
    public class Friend
    {
        public int Id { get; set; } 
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
