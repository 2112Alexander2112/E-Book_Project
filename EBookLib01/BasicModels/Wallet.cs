using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EBookLib01.BasicModels
{
    
    public class Wallet
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int UserId { get; set; } 

        public virtual User User { get; set; }
    }
}
