using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace EBookLib01
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

    }
}
