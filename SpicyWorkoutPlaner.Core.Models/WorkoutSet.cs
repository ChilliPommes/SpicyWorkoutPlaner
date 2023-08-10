using MongoDB.Bson;
using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public partial class WorkoutSet : IRealmObject, IDataBaseCore
    {
        [Indexed]
        public string WorkoutExerciseId { get; set; }

        // Interface impl.

        [PrimaryKey]
        public ObjectId Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
