using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLog.Models
{
    public class Exercise : BaseModel
    {
        public int ExerciseTypeId { get; set; }
        [ForeignKey("ExerciseTypeId")]
        [Display(Name = "Exercise Type")]
        public ExerciseType ExerciseType { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}