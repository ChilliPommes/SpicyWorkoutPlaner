using MongoDB.Bson;
using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public partial class WorkoutExercise : IRealmObject, IDataBaseCore
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Indexed]
        public string WorkoutId { get; set; }

        [Indexed]
        public string ImageId { get; set; }

        // Interface impl.

        [PrimaryKey]
        public ObjectId Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
