﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{

    public class Publisherr
    {
        public int Id { get; set; } 
        public string PublisherName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}