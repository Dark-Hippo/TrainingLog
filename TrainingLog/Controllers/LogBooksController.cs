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
            vm.LogBooks = Db.LogBooks.ToList();

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

        public ActionResult Details(int? id)
        {
            var logBookId = id.GetValueOrDefault();

            if (logBookId == 0)
                return RedirectToAction("Index");

            var logBook = Db.LogBooks.Find(logBookId);

            var vm = new LogBookViewModel
            {
                Name = logBook.Name,
                StartDate = logBook.StartDate,
                Logs = new List<Log>()
            };

            if(logBook.Logs != null)
                vm.Logs.AddRange(logBook.Logs);

            return View(vm);
        }
    }
}