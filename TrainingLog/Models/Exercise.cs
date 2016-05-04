using System.Collections.Generic;

namespace TrainingLog.Models
{
    public class Exercise : BaseModel
    {
        public int Id { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}