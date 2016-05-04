using System;
using System.ComponentModel.DataAnnotations;

namespace TrainingLog.Models
{
    public class BaseModel : IBaseModel
    {
        [Key]
        public int Id { get; }

        private DateTime dateAdded;
        public DateTime DateAdded { get { return dateAdded; } set { dateAdded = DateTime.UtcNow; } }

        private DateTime lastUpdated;
        public DateTime LastUpdated { get { return lastUpdated; } set { lastUpdated = DateTime.UtcNow; } }

    }
}