using SpicyWorkoutPlaner.Core.Models;
using SQLite;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutSet : DataBaseCore
    {
        [Indexed]
        public long WorkoutExerciseId { get; set; }
    }
}
