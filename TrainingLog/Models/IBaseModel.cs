using System;
using System.ComponentModel.DataAnnotations;

namespace TrainingLog.Models
{
    public interface IBaseModel
    {
        [Key]
        int Id { get; }
        DateTime DateAdded { get; set; }
        DateTime LastUpdated { get; set; }
    }
}