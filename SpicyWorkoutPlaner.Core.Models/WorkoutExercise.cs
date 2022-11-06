using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public sealed class WorkoutExercise : RealmObject, IDataBaseCore
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Indexed]
        public string WorkoutId { get; set; }

        [Indexed]
        public string ImageId { get; set; }

        // Interface impl.

        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
