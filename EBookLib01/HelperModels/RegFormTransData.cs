using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.HelperModels
{
    public class RegFormTransData
    {
       
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
        public string RoleId { get; set; }
        public int PublisherId { get; set; }
    }
}
