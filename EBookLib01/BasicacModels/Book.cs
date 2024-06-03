using EBookLib01.BasicacModels;
using EBookLib01.ServiceModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{
    
    public class Book
    {
        [Required]
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        public string AlterName { get; set; }
        public DateTime Published { get; set; }
        public int PublisherId { get; set; }
        public string Image {  get; set; }
        public int BookInfoId { get; set; }
        public decimal BookPrice { get; set; }  
        public virtual BookInfo BookInfo { get; set; }
        public virtual Publisherr Publisherrr { get; set; }    
        public virtual Genre Genre { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Wishlist> Wishlists { get; set; }
        public virtual List<Transaction> Transactions { get; set; } 
        

    }
}
