using System;
using System.Collections.Generic;

namespace TrainingLog.Models
{
    public class Log : BaseModel
    {
        public DateTime Date { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
