using Realms;
using SpicyWorkoutPlaner.Core.Models;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutSet : RealmObject, IDataBaseCore
    {
        [Indexed]
        public long WorkoutExerciseId { get; set; }

        // Interface impl.

        [PrimaryKey]
        public long Id { get; set; }

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
