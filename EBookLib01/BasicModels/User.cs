using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicModels
{
    [Serializable]
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
        public int RoleId { get; set; }
        public int PublisherId { get; set; }

        public virtual List<Wishlist> Wishlist { get; set; }
        public virtual List<MyLibrary> MyLibraries { get; set; }

        public virtual List<Friend> Friends { get; set; }
        public virtual Role Role { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}