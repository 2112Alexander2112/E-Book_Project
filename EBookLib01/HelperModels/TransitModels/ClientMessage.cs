using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EBookLib01.BasicModels;

namespace EBookLib01.HelperModels.TransitModels
{
    public class ClientMessage
    {
        public string Header { get; set; } // Назва запиту
        public User AuthUser { get; set; }
        public string RegUser { get; set; }
        public RegFormTransData RegTrans {  get; set; }
        public string SeacrhingBook { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int WishlistId { get; set; }
    }
}
