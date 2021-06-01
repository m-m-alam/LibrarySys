using System;
using System.Collections.Generic;
using System.Text;
using LibrarySys.Data;

namespace Library.Framework
{
    public class BookUnitOfWork : UnitOfWork, IBookUnitOfWork
    {
        public IBookRepository BookRepository { get; set; }

        public BookUnitOfWork(FrameworkContext context, IBookRepository bookRepositroy)
            : base(context)
        {
            BookRepository = bookRepositroy;
        }
    }
}
