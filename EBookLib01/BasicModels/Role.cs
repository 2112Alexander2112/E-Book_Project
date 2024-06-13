using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicModels
{
   
    public class Role
    {
        [Required]
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
