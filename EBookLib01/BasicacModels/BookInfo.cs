using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{

    public class BookInfo
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string BookName { get; set; }
        public string AlterName { get; set; }
    }
}
