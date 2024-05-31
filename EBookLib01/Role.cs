using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace EBookLib01
{
    [Serializable]
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
