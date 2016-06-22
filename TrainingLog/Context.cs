using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainingLog.Models;

namespace TrainingLog
{
    public class TrainingLogContext : DbContext
    {
        public DbSet<LogBook> LogBooks { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Set> Sets { get; set; }
    }
}