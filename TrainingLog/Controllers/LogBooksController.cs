using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingLog.ViewModels;

namespace TrainingLog.Controllers
{
    public class LogBooksController : Controller
    {
        // GET: LogBooks
        public ActionResult Index()
        {
            var vm = new LogBooksViewModel();
            return View(vm);
        }

        public ActionResult Create()
        {
            return View(new LogBooksViewModel());
        }
    }
}