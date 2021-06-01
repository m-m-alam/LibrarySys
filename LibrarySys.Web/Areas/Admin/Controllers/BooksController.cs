using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Devskill.LibrarySystem.Web.Areas.Admin.Models;
using LibrarySys.Web.Areas.Admin.Models.BookModels;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySys.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<BooksModel>();
            return View(model);
        }
        public IActionResult Add()
        {
            var model = new CreateBookModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(CreateBookModel model)
        {
            if (ModelState.IsValid)
            {
                model.Create();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var model = new EditBookModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditBookModel model)
        {
            if (ModelState.IsValid)
            {
                model.Edit();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new BooksModel();
                model.Delete(id);
                return RedirectToAction("Index");
                
            }
            return RedirectToAction("index");
        }
        public IActionResult GetBooks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<BooksModel>();
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}
