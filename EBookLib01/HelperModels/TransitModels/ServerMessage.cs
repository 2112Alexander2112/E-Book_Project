using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.HelperModels.TransitModels
{
    public class ServerMessage
    {
        public string Header { get; set; }
        public string Messagge { get; set; }
        public Book FindedBook { get; set; }
        public User User { get; set; }
        public List<Book> Books { get; set;}

    }
}
