using MongoDB.Bson;
using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public sealed class Workout : RealmObject, IDataBaseCore
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Interface impl.

        [PrimaryKey]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        public bool IsFlex { get; set; }

        public bool IsStatic { get; set; }

        [Required]
        public DateTimeOffset? CreatedAt { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
