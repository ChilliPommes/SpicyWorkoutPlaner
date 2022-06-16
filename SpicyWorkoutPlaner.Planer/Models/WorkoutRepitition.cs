using Realms;
using SpicyWorkoutPlaner.Core.Models;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class WorkoutRepitition : RealmObject, IDataBaseCore
    {
        [Indexed]
        public long WorkoutSetId { get; set; }

        public short Weight { get; set; }

        // Interface impl.

        [PrimaryKey]
        public long Id { get; set; }

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
