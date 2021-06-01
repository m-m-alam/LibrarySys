using Library.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySys.Web.Areas.Admin.Models.BookModels
{
    public class EditBookModel : BookBaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }

        public EditBookModel():base()
        {
            
        }
        public EditBookModel(IBookService bookService): base(bookService)
        {
            
        }

        public void Load(int id)
        {
            var book = _bookService.GetBook(id);
            if(book!= null)
            {
                this.Id = book.Id;
                this.Title = book.Title;
                this.Author = book.Author;
                this.Edition = book.Edition;

            }
        }

        public void Edit()
        {
            var entity = new Book
            {
                Id = this.Id,
                Title = this.Title,
                Author = this.Author,
                Edition = this.Edition
            };
            _bookService.EditBook(entity);
        }
    }
}
