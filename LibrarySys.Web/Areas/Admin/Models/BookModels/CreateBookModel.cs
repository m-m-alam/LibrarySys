using Autofac;
using Library.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySys.Web.Areas.Admin.Models.BookModels
{
    public class CreateBookModel:AdminBaseModel, IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }

        protected readonly IBookService _bookService;

        public CreateBookModel() {
            _bookService = Startup.AutofacContainer.Resolve<IBookService>();
        }
        public CreateBookModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void Create()
        {
            var entity = new Book
            {
                Title = this.Title,
                Author = this.Author,
                Edition = this.Edition,
                PublicationDate = DateTime.Now
            };
            _bookService.CreateBook(entity);
        }
        public void Dispose()
        {
            _bookService?.Dispose();
        }
    }
}
