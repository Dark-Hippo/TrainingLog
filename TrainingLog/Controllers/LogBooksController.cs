using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingLog.Models;
using TrainingLog.ViewModels;

namespace TrainingLog.Controllers
{
    public class LogBooksController : Controller
    {
        TrainingLogContext Db = new TrainingLogContext();

        // GET: LogBooks
        public ActionResult Index()
        {
            var vm = new LogBooksViewModel();
            return View(vm);
        }

        public ActionResult Create()
        {
            return View(new LogBookViewModel());
        }

        [HttpPost]
        public ActionResult Create(LogBookViewModel vm)
        {
            var logBook = new LogBook()
            {
                Name = vm.Name,
                StartDate = vm.StartDate,
                DateAdded = DateTime.Now,
                LastUpdated = DateTime.Now
                
            };

            Db.LogBooks.Add(logBook);
            Db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}