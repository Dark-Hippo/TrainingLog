using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLog.Models
{
    public class Log : BaseModel
    {
        public int LogBookId { get; set; }
        [ForeignKey("LogBookId")]
        public LogBook LogBook { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
