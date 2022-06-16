using Realms;
using SpicyWorkoutPlaner.Core.Models;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class Workout : RealmObject, IDataBaseCore
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Interface impl.

        [PrimaryKey]
        public long Id { get; set; }

        [Required]
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
