using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework
{
    public interface IBookService : IDisposable
    {
        (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateBook(Book book);
        Book GetBook(int id);
        void EditBook(Book book);
        Book DeleteBook(int id);
    }
}
