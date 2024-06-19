using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicModels
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
        public decimal Price { get; set; }
        public string IconPath { get; set; }
        
        public virtual Publisher Publisher { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<MyLibrary> MyLibraies { get; set; }
    }
}
