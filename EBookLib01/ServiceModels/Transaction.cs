using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBookLib01.BasicacModels;

namespace EBookLib01.ServiceModels
{
    public class Transaction
    {
        public int Id { get; set; } 
        public decimal TransactionValue { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
