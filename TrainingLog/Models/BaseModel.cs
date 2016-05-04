using System;

namespace TrainingLog.Models
{
    public class BaseModel : IBaseModel
    {
        public int Id { get; }

        private DateTime dateAdded;
        public DateTime DateAdded { get { return dateAdded; } set { dateAdded = DateTime.UtcNow; } }

        private DateTime lastUpdated;
        public DateTime LastUpdated { get { return lastUpdated; } set { lastUpdated = DateTime.UtcNow; } }

    }
}