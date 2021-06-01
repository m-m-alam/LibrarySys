using System;
using System.Collections.Generic;
using System.Text;
using LibrarySys.Data;

namespace Library.Framework
{
    public class BookRepository : Repository<Book, int, FrameworkContext>,
        IBookRepository
    {
        public BookRepository(FrameworkContext context) : base(context) { }
    }
}
