using SpicyWorkoutPlaner.Core.Models;
using SQLite;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutRepitition : DataBaseCore
    {
        [Indexed]
        public long WorkoutSetId { get; set; }

        public short Weight { get; set; }
    }
}
