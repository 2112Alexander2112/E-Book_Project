using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBookLib01.BasicacModels;

namespace EBookLib01.ServiceModels
{
    public class ServerMessage
    {
        public string Messagge { get; set; }
        public Book FindedBook { get; set; }
        
    }
}
