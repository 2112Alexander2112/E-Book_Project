using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.HelperModels.TransitModels
{
    public class ClientMessage
    {
        public string Header { get; set; } // Назва запиту
        public string AuthUser { get; set; }
        public string RegUser { get; set; }
        public string SeacrhingBook { get; set; }
    }
}
