using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLog.Models;

namespace TrainingLog.ViewModels
{
    public class LogBooksViewModel
    {
        public LogBooksViewModel()
        {
            LogBooks = new List<LogBook>();
        }
        public ICollection<LogBook> LogBooks { get; set; }
    }
}
