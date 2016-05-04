using System;

namespace TrainingLog.Models
{
    public class BaseModel : IBaseModel
    {
        public DateTime DateAdded { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}