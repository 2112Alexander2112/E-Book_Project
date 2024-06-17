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
<<<<<<< HEAD
        //public string SeacrhingBook { get; set; }
        public RegFormTransData RegTrans {  get; set; }
=======
        public string SeacrhingBook { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
>>>>>>> f99b99c8f4b677262965d471c63f36584d802c9d
    }
}
