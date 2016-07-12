using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLog.Models;

namespace TrainingLog.ViewModels
{
    public class LogsViewModel
    {
        public DateTime Date { get; set; }
        public ExercisesView Exercises { get; set; }
    }

    public class ExercisesView
    {
        public ExercisesView()
        {
            Exercises = new List<Exercise>();
        }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
