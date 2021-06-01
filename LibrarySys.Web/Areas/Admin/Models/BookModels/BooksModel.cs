using Autofac;
using Devskill.LibrarySystem.Web.Areas.Admin.Models;
using Library.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySys.Web.Areas.Admin.Models.BookModels
{
    public class BooksModel : BookBaseModel
    {        
        
        public BooksModel(IBookService bookService): base(bookService)
        {
            
        }
        public BooksModel() : base()
        {

        }

        internal object GetBooks(DataTablesAjaxRequestModel tableModel)
        {
            var data = _bookService.GetBooks(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.Author,
                                record.Edition,
                                record.PublicationDate.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }
        
        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}
