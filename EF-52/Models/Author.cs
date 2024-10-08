﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_52.Models
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public ICollection<Nationality> Nationalities { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
