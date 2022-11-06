using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public sealed class WorkoutRepitition : RealmObject, IDataBaseCore
    {
        [Indexed]
        public string WorkoutSetId { get; set; }

        public short Weight { get; set; }

        // Interface impl.

        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
