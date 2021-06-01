using System;
using System.Collections.Generic;
using System.Text;
using LibrarySys.Data;

namespace Library.Framework
{
    public interface IBookRepository : IRepository<Book, int, FrameworkContext>
    {
        
    }
}
