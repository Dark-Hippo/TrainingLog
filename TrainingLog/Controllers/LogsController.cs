using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingLog.Models;

namespace TrainingLog.Controllers
{
    public class LogsController : Controller
    {
        Context db = new Context();

        // GET: Logs
        public ActionResult Index()
        {
            var logs = db.Logs.ToList();
            return View(logs);
        }

        // GET: Logs/Create
        public ActionResult Create()
        {
            var log = new Log();
            return View(log);
        }
    }
}