using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicModels
{

    public class User
    {
        [Required]
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
        public int PublisherId { get; set; }
        public virtual List<Friend> Friends { get; set; }
        public virtual Publisher Publisher { get; set; }

       // public virtual List<MyLibrary> MyLibraies { get; set; }
    }

}