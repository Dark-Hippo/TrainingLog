using System;

namespace TrainingLog.Models
{
    public interface IBaseModel
    {
        DateTime DateAdded { get; set; }
        DateTime LastUpdated { get; set; }
    }
}