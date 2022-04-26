using SpicyWorkoutPlaner.Core.Models;
using SQLite;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutExercise : DataBaseCore
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Indexed]
        public long WorkoutId { get; set; }

        [Indexed]
        public long ImageId { get; set; }
    }
}
