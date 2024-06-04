using System;

namespace EBookLib01.BasicModels
{
    [Serializable]
    public class BookStatistic
    {
        
        public int Id { get; set; }
        public float TotalRaiting { get; set; }
        public int Sells { get; set; }
        public int BookId { get; set; }
        public int InNumberOfWishLists { get; set; }

        public virtual Book Book { get; set; }
    }
}
