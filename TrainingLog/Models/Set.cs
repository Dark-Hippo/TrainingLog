namespace TrainingLog.Models
{
    public class Set : BaseModel
    {
        public int Id { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }
    }
}