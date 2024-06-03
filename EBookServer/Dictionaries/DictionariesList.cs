using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBookLib01.BasicacModels;

namespace EBookServer.Dictionaries
{
    internal class DictionariesList
    {
        public List<Achievement> Achievements { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<BookInfo> BookInfos { get; set; }
        public List<BookSeries> Series { get; set; }
        public List<BookStatistic> Statistics { get; set; }
        public List<Category> Category { get; set; }    
        public List<Friend> Friends { get; set; }
        public List<Genre> Genres { get; set; }
        public List<MyLibrary> MyLibraries { get; set; }
        public List<Publisherr> Publisherrs { get; set; }    
        
    }
}
