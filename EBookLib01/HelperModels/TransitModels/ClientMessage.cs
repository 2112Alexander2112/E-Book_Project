using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.HelperModels.TransitModels
{
    public class ClientMessage
    {
        public string Header { get; set; }
        public string AuthUser { get; set; }
        public string SeacrhingBook { get; set; }
        public string ResetPass { get; set; }

        public User RegUser { get; set; }
    }
}
