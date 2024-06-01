using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01
{
    [Serializable]
    public class Role
    {
        [Required]
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
