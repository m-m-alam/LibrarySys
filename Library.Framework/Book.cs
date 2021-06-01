using LibrarySys.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }
    }
}
