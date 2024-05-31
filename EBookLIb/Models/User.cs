using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EBookLIb.Models
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string UserLogin { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime RegDate { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
