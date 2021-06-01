using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Framework
{
    public class BookService : IBookService, IDisposable
    {
        private IBookUnitOfWork _bookUnitOfWork;
        public BookService(IBookUnitOfWork bookUnitOfWork)
        {
            _bookUnitOfWork = bookUnitOfWork;
        }
        public void CreateBook(Book book)
        {
            _bookUnitOfWork.BookRepository.Add(book);
            _bookUnitOfWork.Save();
        }

        public Book DeleteBook(int id)
        {
            var book = _bookUnitOfWork.BookRepository.GetById(id);
            _bookUnitOfWork.BookRepository.Remove(book);
            _bookUnitOfWork.Save();
            return book;
        }

        public void Dispose()
        {
            _bookUnitOfWork?.Dispose(); 
        }

        public void EditBook(Book book)
        {
            var existingBook =_bookUnitOfWork.BookRepository.GetById(book.Id);
            existingBook.Author = book.Author;
            existingBook.Edition = book.Edition;
            existingBook.PublicationDate = book.PublicationDate;
            existingBook.Title = book.Title;

            _bookUnitOfWork.Save();

        }

        public Book GetBook(int id)
        {
            return _bookUnitOfWork.BookRepository.GetById(id);
        }

        public (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _bookUnitOfWork.BookRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
