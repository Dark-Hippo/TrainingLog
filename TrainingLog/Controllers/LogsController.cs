using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingLog.Models;
using TrainingLog.ViewModels;

namespace TrainingLog.Controllers
{
    public class LogsController : Controller
    {
        TrainingLogContext db = new TrainingLogContext();

        // GET: Logs
        public ActionResult Index()
        {
            var logs = db.Logs.ToList();
            return View(logs);
        }

        // GET: Logs/Create
        public ActionResult Create()
        {
            var log = new LogsViewModel();
            return View(log);
        }
    }
}