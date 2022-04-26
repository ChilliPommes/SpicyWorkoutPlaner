using SpicyWorkoutPlaner.Core.Models;
using SQLite;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutSet : DataBaseCore
    {
        [Indexed]
        public long WorkoutExerciseId { get; set; }

        // TODO List darf ich nicht machen
        public List<string> Notes { get; set; }
    }
}
