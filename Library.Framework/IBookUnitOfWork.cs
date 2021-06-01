using LibrarySys.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework
{
    public interface IBookUnitOfWork : IUnitOfWork
    {
        IBookRepository BookRepository { get; set; }
    }
}
