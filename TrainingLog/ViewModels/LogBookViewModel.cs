using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLog.ViewModels
{
    public class LogBookViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
    }
}
