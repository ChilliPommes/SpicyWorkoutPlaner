using MongoDB.Bson;
using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public partial class Workout : IRealmObject, IDataBaseCore
    {
        [PrimaryKey]
        public ObjectId Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsFlex { get; set; }

        public bool IsStatic { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
