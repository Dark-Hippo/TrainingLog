using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLog.Models;

namespace TrainingLog
{
    class Initialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrainingLogContext>
    {
        protected override void Seed(TrainingLogContext context)
        {
            context.ExerciseTypes.AddOrUpdate(m => m.Id,
                new ExerciseType { Name = "Squat" },
                new ExerciseType { Name = "Press" },
                new ExerciseType { Name = "Chin-up" },
                new ExerciseType { Name = "Front squat" },
                new ExerciseType { Name = "Inverted row" }
                );

            context.SaveChanges();
        }
    }
}
