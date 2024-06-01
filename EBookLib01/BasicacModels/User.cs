using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;
using EBookLib01.BasicacModels;

namespace EBookLib01.BasicacModels
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
        public int PublicsherId { get; set; }

        public virtual List<Wishlist> Wishlist { get; set; } 
        public virtual List<MyLibrary> MyLibraries { get; set; }

        public virtual List<Friend> Friends { get; set; }
        public virtual Role Role { get; set; }
        public virtual Publisherr Publisher { get; set; }
    }
}
