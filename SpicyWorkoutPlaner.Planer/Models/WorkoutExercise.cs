using Realms;
using SpicyWorkoutPlaner.Core.Models;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutExercise : RealmObject, IDataBaseCore
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Indexed]
        public long WorkoutId { get; set; }

        [Indexed]
        public long ImageId { get; set; }

        // Interface impl.

        [PrimaryKey]
        public long Id { get; set; }

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
